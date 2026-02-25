using System;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Sound.View
{
	// Token: 0x02000C73 RID: 3187
	[Token(Token = "0x2000C73")]
	public class PlaySoundOnVisibleComponent : PlaySoundComponent
	{
		// Token: 0x06004DD1 RID: 19921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x9C09", Offset = "0x9C09", VA = "0x9C09")]
		private void OnEnable()
		{
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x9C0A", Offset = "0x9C0A", VA = "0x9C0A")]
		public PlaySoundOnVisibleComponent()
		{
		}

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Sounds _sound;
	}
}
