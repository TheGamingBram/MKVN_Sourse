#include <kamek.hpp>
#include <core/nw4r/ut/Misc.hpp>
#include <core/nw4r/snd/StrmFile.hpp>
#include <core/nw4r/snd/StrmSound.hpp>
#include <core/nw4r/snd/DVDSoundArchive.hpp>

namespace Pulsar {
namespace Sound {
using namespace nw4r;
//Reimplementation of CTGP's BRSTM volume patch
bool LoadBRSTMVolumeAndFixTrackCount(snd::detail::StrmFileLoader& fileLoader, snd::detail::StrmFileReader::StrmInfo& info) {
    register snd::detail::StrmSound* sound;
    asm(subi sound, r29, 0x100);

    u8 volume = *reinterpret_cast<const u8*>(ut::AddU32ToPtr(fileLoader.fileReader.header, 0x3F));
    if(volume != 0) {

        const u32 maxVolume = 0x7F;
        if(volume > maxVolume) volume = maxVolume;
        sound->mainOutVolume = (float)volume / (float)maxVolume;
    }
    bool ret = fileLoader.ReadStrmInfo(&info);
    if(ret) {
        sound->strmPlayer.channelsNeeded = ut::Min(sound->strmPlayer.channelsNeeded, info.channelCount);
        sound->strmPlayer.trackCount = ut::Min(sound->strmPlayer.trackCount, info.channelCount / 2);
    }
    return ret;
}
kmCall(0x800a66f4, LoadBRSTMVolumeAndFixTrackCount);
//kmWrite32(0x800a66f0, 0x389DFF00);

//Automatic BRSAR patching from Elias_
void BRSAREntrySizePatch(snd::DVDSoundArchive::DVDFileStream* stream, s32 offset, u32 origin) {
    stream->size = 0x7FFFFFFF;
    stream->Seek(offset, origin);
}
kmCall(0x80091354, BRSAREntrySizePatch);




}//namespace Audio
}//namespace Pulsar