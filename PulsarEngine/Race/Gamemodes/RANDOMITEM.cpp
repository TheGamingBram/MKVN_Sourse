#include <kamek.hpp>
#include <Settings/Settings.hpp>
#include <MarioKartWii/RKNet/RKNetController.hpp>
#include <MKVN.hpp>

namespace MKVN {
namespace Race{
    void EqualItem(){
        U32_RANDOMITEM_HOOK = 0x80a10054;
        if(System::GetGamemode() == RACESETTING_MODE_RANDOM){
            U32_RANDOMITEM_HOOK = 0x38A0000A;
        }
        System::CacheInvalidateAddress(U32_RANDOMITEM_HOOK);
    }  
Pulsar::Settings::Hook RANDOMITEM(EqualItem);
}
}