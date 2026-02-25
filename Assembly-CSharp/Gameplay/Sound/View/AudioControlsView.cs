using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Sound.View
{
	// Token: 0x02000C6F RID: 3183
	[Token(Token = "0x2000C6F")]
	public class AudioControlsView : MonoBehaviour
	{
		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06004DC7 RID: 19911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FC1")]
		public Toggle SoundFX
		{
			[Token(Token = "0x6004DC7")]
			[Address(RVA = "0x9BFF", Offset = "0x9BFF", VA = "0x9BFF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FC2")]
		public Toggle Music
		{
			[Token(Token = "0x6004DC8")]
			[Address(RVA = "0x9C00", Offset = "0x9C00", VA = "0x9C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x9C01", Offset = "0x9C01", VA = "0x9C01")]
		public AudioControlsView()
		{
		}

		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Toggle _soundFX;

		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _music;
	}
}
