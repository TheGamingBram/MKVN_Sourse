#include <kamek.hpp>
#include <Settings/Settings.hpp>
#include <MarioKartWii/RKNet/RKNetController.hpp>
#include <MKVN.hpp>

namespace MKVN {
namespace Network{
void ChangeRegion(){
    // THIS USES https://mariokartwii.com/showthread.php?tid=59 USE REGION DEC TO HEX!

    // REGIONS USED BY VNIGHT
    // NORMAL GAMEMODE          : 444   : 1BC
    // RANDOM ITEMS GAMEMODE    : 445   : 1BD
    // MUSHROOMS ONLY           : X     : X     (PLANNED REQUEST)
    // BOB-OMB BLAST            : X     : X     (PLANNED REQUEST)
    // BLUE SELL SHOWDOWN       : X     : X     (PLANNED REQUEST)
    // CHAOTIC MODE             : X     : X     (PLANNED REQUEST)
    // MKVN LEGACY (OLD 3.5)    : X     : X     (PLANNED REQUEST)

    // BRAM! YOU NEED TO REQUEST THE WIIMFI REGIONS!
    
    

    RKNetController_Search1 = 0x38A001BC; 
    RKNetController_Search2 = 0x38C001BC;
    RKNetController_Search3 = 0x38E001BC;
    RKNetController_Search4 = 0x38E001BC;
    RKNetController_Search5 = 0x38E001BC;
    RKNetController_Search6 = 0x38E001BC;
    RKNetController_Search7 = 0x388000BC;
    RKNetController_Search8 = 0x388000BC;
    if(System::GetGamemode() == RACESETTING_MODE_RANDOM){
        RKNetController_Search1 = 0x38A001BD; 
        RKNetController_Search2 = 0x38C001BD;
        RKNetController_Search3 = 0x38E001BD;
        RKNetController_Search4 = 0x38E001BD;
        RKNetController_Search5 = 0x38E001BD;
        RKNetController_Search6 = 0x38E001BD;
        RKNetController_Search7 = 0x388000BD;
        RKNetController_Search8 = 0x388000BD;
    }
    else if(System::GetGamemode() == RACESETTING_MODE_MUSHROOM){
        // RKNetController_Search1 = 0x38A001BC; 
        // RKNetController_Search2 = 0x38C001BC;
        // RKNetController_Search3 = 0x38E001BC;
        // RKNetController_Search4 = 0x38E001BC;
        // RKNetController_Search5 = 0x38E001BC;
        // RKNetController_Search6 = 0x38E001BC;
        // RKNetController_Search7 = 0x388000BC;
        // RKNetController_Search8 = 0x388000BC;
    }
    else if(System::GetGamemode() == RACESETTING_MODE_BBB){
        // RKNetController_Search1 = 0x38A001BC; 
        // RKNetController_Search2 = 0x38C001BC;
        // RKNetController_Search3 = 0x38E001BC;
        // RKNetController_Search4 = 0x38E001BC;
        // RKNetController_Search5 = 0x38E001BC;
        // RKNetController_Search6 = 0x38E001BC;
        // RKNetController_Search7 = 0x388000BC;
        // RKNetController_Search8 = 0x388000BC;
    }
    else if(System::GetGamemode() == RACESETTING_MODE_BSS){
        // RKNetController_Search1 = 0x38A001BC; 
        // RKNetController_Search2 = 0x38C001BC;
        // RKNetController_Search3 = 0x38E001BC;
        // RKNetController_Search4 = 0x38E001BC;
        // RKNetController_Search5 = 0x38E001BC;
        // RKNetController_Search6 = 0x38E001BC;
        // RKNetController_Search7 = 0x388000BC;
        // RKNetController_Search8 = 0x388000BC;
    }
    else if(System::GetGamemode() == RACESETTING_MODE_CHAOTIC){
        // RKNetController_Search1 = 0x38A001BC; 
        // RKNetController_Search2 = 0x38C001BC;
        // RKNetController_Search3 = 0x38E001BC;
        // RKNetController_Search4 = 0x38E001BC;
        // RKNetController_Search5 = 0x38E001BC;
        // RKNetController_Search6 = 0x38E001BC;
        // RKNetController_Search7 = 0x388000BC;
        // RKNetController_Search8 = 0x388000BC;
    }
    System::CacheInvalidateAddress(RKNetController_Search1);
    System::CacheInvalidateAddress(RKNetController_Search2);
    System::CacheInvalidateAddress(RKNetController_Search3);
    System::CacheInvalidateAddress(RKNetController_Search4);
    System::CacheInvalidateAddress(RKNetController_Search5);
    System::CacheInvalidateAddress(RKNetController_Search6);
    System::CacheInvalidateAddress(RKNetController_Search7);
    System::CacheInvalidateAddress(RKNetController_Search8);
}

Pulsar::Settings::Hook PatchSearchRegion(ChangeRegion);
} // namespace Network
} // namespace MKVN