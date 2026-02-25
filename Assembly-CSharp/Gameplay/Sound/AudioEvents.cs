using System;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Sound
{
	// Token: 0x02000C6E RID: 3182
	[Token(Token = "0x2000C6E")]
	public class AudioEvents : AbstractMVCEvents
	{
		// Token: 0x06004DC6 RID: 19910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC6")]
		[Address(RVA = "0x9BFE", Offset = "0x9BFE", VA = "0x9BFE")]
		public AudioEvents()
		{
		}

		// Token: 0x04002A57 RID: 10839
		[Token(Token = "0x4002A57")]
		[FieldOffset(Offset = "0x14")]
		public Action<AudioClip> PlayMusicEvent;

		// Token: 0x04002A58 RID: 10840
		[Token(Token = "0x4002A58")]
		[FieldOffset(Offset = "0x18")]
		public Action<AudioClip> PlaySoundEvent;

		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		[FieldOffset(Offset = "0x1C")]
		public Action StopMusicEvent;
	}
}
