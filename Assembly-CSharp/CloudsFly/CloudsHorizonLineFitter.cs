using System;
using System.Collections;
using CloudsFly.WebGL;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012FD RID: 4861
	[Token(Token = "0x20012FD")]
	public class CloudsHorizonLineFitter : MonoBehaviour
	{
		// Token: 0x060073AC RID: 29612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AC")]
		[Address(RVA = "0xBD93", Offset = "0xBD93", VA = "0xBD93")]
		private void OnDisable()
		{
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AD")]
		[Address(RVA = "0xBD94", Offset = "0xBD94", VA = "0xBD94")]
		private void OnEnable()
		{
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AE")]
		[Address(RVA = "0xBD95", Offset = "0xBD95", VA = "0xBD95")]
		private void OnGameContentScaledEvent()
		{
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073AF")]
		[Address(RVA = "0xBD96", Offset = "0xBD96", VA = "0xBD96")]
		private IEnumerator AdaptRoutine()
		{
			return null;
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B0")]
		[Address(RVA = "0xBD97", Offset = "0xBD97", VA = "0xBD97")]
		public CloudsHorizonLineFitter()
		{
		}

		// Token: 0x04003C94 RID: 15508
		[Token(Token = "0x4003C94")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _background;

		// Token: 0x04003C95 RID: 15509
		[Token(Token = "0x4003C95")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _backgroundContainer;

		// Token: 0x04003C96 RID: 15510
		[Token(Token = "0x4003C96")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04003C97 RID: 15511
		[Token(Token = "0x4003C97")]
		[FieldOffset(Offset = "0x1C")]
		private readonly CloudsHorizonSolver _cloudsHorizonSolver;
	}
}
