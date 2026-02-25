using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public abstract class AbstractFpsCounter : MonoBehaviour
	{
		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x56DE", Offset = "0x56DE", VA = "0x56DE")]
		private void Update()
		{
		}

		// Token: 0x0600023A RID: 570
		[Token(Token = "0x600023A")]
		public abstract void HandleUpdate();

		// Token: 0x0600023B RID: 571
		[Token(Token = "0x600023B")]
		public abstract void HandleFpsCalculated(float fps);

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x56DF", Offset = "0x56DF", VA = "0x56DF")]
		protected AbstractFpsCounter()
		{
		}

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _refreshInterval;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x14")]
		private float _totalFrames;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x18")]
		private float _timePassed;
	}
}
