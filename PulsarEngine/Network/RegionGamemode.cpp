#include <kamek.hpp>
#include <Settings/Settings.hpp>
#include <MarioKartWii/RKNet/RKNetController.hpp>
#include <MKVN.hpp>

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

namespace MKVN {
namespace Network{
void ResetGamemodeAndTimer(){
    System *mkvn = System::GetsInstance();
        //mkvn->isRegModeSelected = false;
        mkvn->vrScreenTimer = 0;
    }
kmBranch(0x8064a848, ResetGamemodeAndTimer);
} // namespace Network
} // namespace VP