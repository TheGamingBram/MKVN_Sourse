#ifndef _MKVN_
#define _MKVN_
#include <kamek.hpp>
#include <PulsarSystem.hpp>
#include <Settings/Settings.hpp>
#include <MarioKartWii/Item/Obj/ItemObj.hpp>
#include <MarioKartWii/System/Identifiers.hpp>
#include <MarioKartWii/GlobalFunctions.hpp>
#include <MKVNEnums.hpp>

extern u32 U32_RBBG_HOOK_PT1;
extern u32 U32_RBBG_HOOK_PT2;

namespace MKVN {
class System : public Pulsar::System {
public:
    u8 invincibilityTimer[12];

    Gamemode hostMode;
    bool isRegModeSelected;
    u16 vrScreenTimer;

    KartRestriction kartRestrictMode;
    CharacterRestriction charRestrictMode;

    Transmission transmissions[12];
    u32 lastSelectedTransmissionId;

    static Pulsar::System *Create(); //My Create function, needs to return Pulsar
    static System *GetsInstance(){ return static_cast<System *>(sInstance); } //for ease of use, optional
    static Gamemode GetGamemode();
    static KartRestriction GetKartRestriction();
    static CharacterRestriction GetCharacterRestriction();
    static WeightClass GetWeightClass(CharacterId id);
    static void CreateTransmissionSelectPage();
    static inline int GetGamemodeCount() { return MKVN_GAMEMODE_NONE; }

    u8 SetPackROOMMsg() override {
        hostMode = static_cast<Gamemode>(Pulsar::Settings::Mgr::GetSettingValue(static_cast<Pulsar::Settings::Type>(SETTINGSTYPE_MKVN), SETTINGMKVN_SCROLLER_MODE)); //3 bits
        kartRestrictMode = static_cast<KartRestriction>((Pulsar::Settings::Mgr::GetSettingValue(static_cast<Pulsar::Settings::Type>(SETTINGSTYPE_MKVN), SETTINGMKVN_RADIO_KARTSELECT))); //2 bits
        charRestrictMode = static_cast<CharacterRestriction>((Pulsar::Settings::Mgr::GetSettingValue(static_cast<Pulsar::Settings::Type>(SETTINGSTYPE_MKVN), SETTINGMKVN_RADIO_CHARSELECT))); //3 bits

        u8 ret = hostMode + (kartRestrictMode << 3) + (charRestrictMode << 5);

        return ret;
    };
    void ParsePackROOMMsg(u8 msg) override {
        hostMode = static_cast<Gamemode>(msg & 0b111);
        kartRestrictMode = static_cast<KartRestriction>((msg & 0b11000) >> 3);
        charRestrictMode = static_cast<CharacterRestriction>((msg & 0b11100000) >> 5);
    };
    void AfterInit() override;

    static inline void CacheInvalidateAddress(register u32 address) {
        asm(dcbst 0, address;);
        asm(sync;);
        asm(icbi 0, address;);
        asm(isync;);
    }
};
} // namespace MKVN#
#endif