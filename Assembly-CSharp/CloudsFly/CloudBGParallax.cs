using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CloudsFly
{
	// Token: 0x020012F7 RID: 4855
	[Token(Token = "0x20012F7")]
	public class CloudBGParallax : MonoBehaviour
	{
		// Token: 0x06007389 RID: 29577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007389")]
		[Address(RVA = "0xBD75", Offset = "0xBD75", VA = "0xBD75")]
		public void StartMove()
		{
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600738A")]
		[Address(RVA = "0xBD76", Offset = "0xBD76", VA = "0xBD76")]
		public void StopMove()
		{
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600738B")]
		[Address(RVA = "0xBD77", Offset = "0xBD77", VA = "0xBD77")]
		private IEnumerator MoveBG()
		{
			return null;
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600738C")]
		[Address(RVA = "0xBD78", Offset = "0xBD78", VA = "0xBD78")]
		public CloudBGParallax()
		{
		}

		// Token: 0x04003C74 RID: 15476
		[Token(Token = "0x4003C74")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04003C75 RID: 15477
		[Token(Token = "0x4003C75")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RawImage _background;

		// Token: 0x04003C76 RID: 15478
		[Token(Token = "0x4003C76")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _multiplier;

		// Token: 0x04003C77 RID: 15479
		[Token(Token = "0x4003C77")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 _startPosition;

		// Token: 0x04003C78 RID: 15480
		[Token(Token = "0x4003C78")]
		[FieldOffset(Offset = "0x28")]
		private float _startRectX;

		// Token: 0x04003C79 RID: 15481
		[Token(Token = "0x4003C79")]
		[FieldOffset(Offset = "0x2C")]
		private Coroutine _moveCor;
	}
}
