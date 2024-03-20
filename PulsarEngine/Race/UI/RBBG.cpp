#include <kamek.hpp>
#include <MKVN.hpp>
#include <Settings/Settings.hpp>
#include <PulsarSystem.hpp>

namespace MKVN{
namespace Race{

void Remove_Background_Blur_Glow(){
    U32_RBBG_HOOK_PT1 = 0x03000000;
    U32_RBBG_HOOK_PT2 = 0x3f000000;

    if(Pulsar::Settings::Mgr::GetSettingValue(static_cast<Pulsar::Settings::Type>(SETTINGSTYPE_MKVN),SETTINGMKVN_RADIO_RBBG) == 1){
        U32_RBBG_HOOK_PT1 = 0x00000000; // if settings is true
        U32_RBBG_HOOK_PT2 = 0x30000000;
    }
    System::CacheInvalidateAddress(U32_RBBG_HOOK_PT1);
    System::CacheInvalidateAddress(U32_RBBG_HOOK_PT2);
}
static RaceLoadHook RBBG_Hook(Remove_Background_Blur_Glow);

} // namespace Race
} // namespace MKVN