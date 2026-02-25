using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Sound.View
{
	// Token: 0x02000C70 RID: 3184
	[Token(Token = "0x2000C70")]
	public class GameAudioSource : MonoBehaviour
	{
		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FC3")]
		public AudioSource MusicSource
		{
			[Token(Token = "0x6004DCA")]
			[Address(RVA = "0x9C02", Offset = "0x9C02", VA = "0x9C02")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06004DCB RID: 19915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FC4")]
		public AudioSource SoundSource
		{
			[Token(Token = "0x6004DCB")]
			[Address(RVA = "0x9C03", Offset = "0x9C03", VA = "0x9C03")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x9C04", Offset = "0x9C04", VA = "0x9C04")]
		public GameAudioSource()
		{
		}

		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AudioSource _musicSource;

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AudioSource _soundSource;
	}
}
