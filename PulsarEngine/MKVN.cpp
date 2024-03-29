#include <MarioKartWii/Race/RaceData.hpp>
#include <SlotExpansion/CupsConfig.hpp>
#include <Settings/UI/SettingsPanel.hpp>
#include <MarioKartWii/RKNet/SELECT.hpp>
#include <MarioKartWii/UI/Page/Other/VR.hpp>
#include <MKVN.hpp>

namespace MKVN {
Pulsar::System *System::Create() {
    return new System(); //now Pulsar::sInstance is of type MKVN
}
Pulsar::System::Inherit CreateMKVN(System::Create); //Create a Inherit that'll get called back by Pulsar::CreatePulsar

void System::AfterInit(){
    ++Pulsar::UI::SettingsPanel::pageCount;

    // Radio button count for new page
    Pulsar::UI::SettingsPanel::radioButtonCount[SETTINGSTYPE_MKVN] = 3;
    // Restrict Kart Selection Count i.e. Default/Karts/Bikes
    Pulsar::UI::SettingsPanel::buttonsPerPagePerRow[SETTINGSTYPE_MKVN][0] = 3;
    // Restrict Character Selection Count i.e. Default/Light/Medium/Heavy
    Pulsar::UI::SettingsPanel::buttonsPerPagePerRow[SETTINGSTYPE_MKVN][1] = 4;
    // Background Blur and Glow Toggle
    Pulsar::UI::SettingsPanel::buttonsPerPagePerRow[SETTINGSTYPE_MKVN][2] = 2;

    // Scroller count for new page
    Pulsar::UI::SettingsPanel::scrollerCount[SETTINGSTYPE_MKVN] = 1;
    // Gamemode Scroller Option Count
    Pulsar::UI::SettingsPanel::optionsPerPagePerScroller[SETTINGSTYPE_MKVN][0] = 6;
}

WeightClass System::GetWeightClass(const CharacterId id){
    switch (id)
    {
        case BABY_MARIO:
        case BABY_LUIGI:
        case BABY_PEACH:
        case BABY_DAISY:
        case TOAD:
        case TOADETTE:
        case KOOPA_TROOPA:
        case DRY_BONES:
            return LIGHTWEIGHT;
        case MARIO:
        case LUIGI:
        case PEACH:
        case DAISY:
        case YOSHI:
        case BIRDO:
        case DIDDY_KONG:
        case BOWSER_JR:
            return MEDIUMWEIGHT;
        case WARIO:
        case WALUIGI:
        case DONKEY_KONG:
        case BOWSER:
        case KING_BOO:
        case ROSALINA:
        case FUNKY_KONG:
        case DRY_BOWSER:
            return HEAVYWEIGHT;
        default:
            return MIIS;
    }
}

CharacterRestriction System::GetCharacterRestriction(){
    const GameMode gameMode = RaceData::sInstance->menusScenario.settings.gamemode;
    const bool isFroom = gameMode == MODE_PRIVATE_VS || gameMode == MODE_PRIVATE_BATTLE;
    if (isFroom){
        return GetsInstance()->charRestrictMode;
    }
    return CHAR_DEFAULTSELECTION;
}

KartRestriction System::GetKartRestriction(){
    const GameMode gameMode = RaceData::sInstance->menusScenario.settings.gamemode;
    const bool isFroom = gameMode == MODE_PRIVATE_VS || gameMode == MODE_PRIVATE_BATTLE;
    if (isFroom){
        return GetsInstance()->kartRestrictMode;
    }
    return KART_DEFAULTSELECTION;
}

Gamemode System::GetGamemode(){
    const bool isRegs = Pulsar::CupsConfig::IsRegsSituation();
    const GameMode gameMode = RaceData::sInstance->racesScenario.settings.gamemode;
    const bool isTTs = gameMode == MODE_TIME_TRIAL;
    const bool isFroom = gameMode == MODE_PRIVATE_VS || gameMode == MODE_PRIVATE_BATTLE;
    const bool isRegional = gameMode == MODE_PUBLIC_VS || MODE_PUBLIC_BATTLE;
    if (!isRegs){
        if (!isTTs){
            if (isFroom || isRegional){
                return GetsInstance()->hostMode;
            }
            return static_cast<Gamemode>(Pulsar::Settings::Mgr::GetSettingValue(static_cast<Pulsar::Settings::Type>(SETTINGSTYPE_MKVN), SETTINGMKVN_SCROLLER_MODE));
        }
        return MKVN_GAMEMODE_NORMAL;
    }
    return MKVN_GAMEMODE_NONE;
}

void UpdateVRBMGText(Pages::VR *page){ //assume it's of this type so we can use it's members
    if (page->pageId == PAGE_VR && !Pulsar::CupsConfig::IsRegsSituation()){
        System *mkvn = System::GetsInstance();
        if (mkvn->vrScreenTimer == 0){
            const GameMode gameMode = RaceData::sInstance->menusScenario.settings.gamemode;
            if (gameMode == MODE_PUBLIC_VS || MODE_PRIVATE_VS)
                page->ctrlMenuBottomMessage.SetMessage(BMG_VR_BOTTOM_100CC + (RKNet::SELECTHandler::sInstance->GetEngineClass() - 1));
            else
                page->ctrlMenuBottomMessage.SetMessage(BMG_VR_BOTTOM_BALLOON + (RKNet::SELECTHandler::sInstance->GetBattleType()));
            mkvn->vrScreenTimer = 360;
        }
        else if(mkvn->vrScreenTimer == 180){
            page->ctrlMenuBottomMessage.SetMessage(DISPLAY_GAMEMODE_NORMAL + mkvn->hostMode);
        }
        --mkvn->vrScreenTimer;
    }
}
kmBranch(0x805bb22c, UpdateVRBMGText);
} // namespace MKVN