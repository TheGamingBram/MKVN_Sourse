#include <MKVN.hpp>
#include <kamek.hpp>

namespace MKVN {
namespace Race{}}

//Better Mega FOV [TheLordScruffy]
kmCallDefAsm(0x805793AC) {
loc_0x0:
lwz       r4, 0x0(r28)
lwz       r29, 0x24(r4)
cmpwi     r29, 0
beq-      loc_0x28
lwz       r3, 0x4(r4)
lwz       r3, 0xC(r3)
rlwinm.   r3,r3,0,16,16
beq-      loc_0x28
lis       r0, 0x41F0
stw       r0, 0x120(r29)

loc_0x28:
}