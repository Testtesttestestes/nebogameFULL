using System;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C7E RID: 3198
	[Token(Token = "0x2000C7E")]
	public interface IGameAudio
	{
		// Token: 0x06004E14 RID: 19988
		[Token(Token = "0x6004E14")]
		void PlayMusic(PlayLists playlist);

		// Token: 0x06004E15 RID: 19989
		[Token(Token = "0x6004E15")]
		void PlaySound(Sounds sound);

		// Token: 0x06004E16 RID: 19990
		[Token(Token = "0x6004E16")]
		void PlaySound(AssetDic asset);

		// Token: 0x06004E17 RID: 19991
		[Token(Token = "0x6004E17")]
		void StopMusic();
	}
}
