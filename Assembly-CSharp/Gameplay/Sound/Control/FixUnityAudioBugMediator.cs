using System;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C7D RID: 3197
	[Token(Token = "0x2000C7D")]
	public class FixUnityAudioBugMediator : AudioSourceMediator
	{
		// Token: 0x06004E11 RID: 19985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E11")]
		[Address(RVA = "0x9C48", Offset = "0x9C48", VA = "0x9C48")]
		public FixUnityAudioBugMediator(AudioModel model, AudioEvents events, AudioController controller)
		{
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E12")]
		[Address(RVA = "0x9C49", Offset = "0x9C49", VA = "0x9C49", Slot = "21")]
		protected override void HandlePlaySoundEvent(AudioClip audioClip)
		{
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E13")]
		[Address(RVA = "0x9C4A", Offset = "0x9C4A", VA = "0x9C4A", Slot = "22")]
		protected override void HandlePlayMusicEvent(AudioClip audioClip)
		{
		}
	}
}
