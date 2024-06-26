#ifndef _TRANSMISSION_SELECT_
#define _TRANSMISSION_SELECT_
#include <MKVN.hpp>
#include <MarioKartWii/UI/Page/Menu/KartSelect.hpp>
#include <MarioKartWii/UI/Page/Menu/DriftSelect.hpp>
#include <MarioKartWii/UI/SectionMgr/SectionMgr.hpp>
#include <MarioKartWii/UI/Page/Other/Message.hpp>
#include <UI/ChangeCombo/ChangeCombo.hpp>

namespace MKVN{
namespace UI{
class TransmissionSelect : public Pages::DriftSelect {
public:
    static const PageId id = static_cast<PageId>(PAGE_TRANSMISSION_SELECT);
    TransmissionSelect();
    void OnActivate() override;
    void SetButtonHandlers(PushButton& pushButton) override;
    void BeforeControlUpdate() override;
private:
    void OnButtonClick(PushButton& button, u32 hudSlotId);
    void OnButtonSelect(PushButton& button, u32 hudSlotId);
    void OnBackPress(u32 hudSlotId);
};
} // namespace UI
} // namespace MKVN
#endif