using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameplay.Sound.Model;
using Gameplay.Sound.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C7B RID: 3195
	[Token(Token = "0x2000C7B")]
	public class AudioSourceMediator : AbstractViewMediator<AudioModel, AudioEvents, AudioController, GameAudioSource>
	{
		// Token: 0x06004E07 RID: 19975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E07")]
		[Address(RVA = "0x9C3E", Offset = "0x9C3E", VA = "0x9C3E")]
		public AudioSourceMediator(AudioModel model, AudioEvents events, AudioController controller)
		{
		}

		// Token: 0x17000FD2 RID: 4050
		// (set) Token: 0x06004E08 RID: 19976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FD2")]
		public override AudioEvents Events
		{
			[Token(Token = "0x6004E08")]
			[Address(RVA = "0x9C3F", Offset = "0x9C3F", VA = "0x9C3F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E09")]
		[Address(RVA = "0x9C40", Offset = "0x9C40", VA = "0x9C40")]
		private void StopFade()
		{
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0A")]
		[Address(RVA = "0x9C41", Offset = "0x9C41", VA = "0x9C41")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0B")]
		[Address(RVA = "0x9C42", Offset = "0x9C42", VA = "0x9C42")]
		private void HandleStopMusicEvent()
		{
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0C")]
		[Address(RVA = "0x9C43", Offset = "0x9C43", VA = "0x9C43", Slot = "21")]
		protected virtual void HandlePlaySoundEvent(AudioClip audioClip)
		{
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0D")]
		[Address(RVA = "0x9C44", Offset = "0x9C44", VA = "0x9C44", Slot = "22")]
		protected virtual void HandlePlayMusicEvent(AudioClip audioClip)
		{
		}

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x18")]
		private List<TweenerCore<float, float, FloatOptions>> _fadeTweeners;
	}
}
