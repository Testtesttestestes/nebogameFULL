using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.RateGame.View
{
	// Token: 0x020005A1 RID: 1441
	[Token(Token = "0x20005A1")]
	public class RateGameComponent : MonoBehaviour
	{
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x1700064E")]
		public int Value
		{
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x73E5", Offset = "0x73E5", VA = "0x73E5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600228F")]
		[Address(RVA = "0x73E6", Offset = "0x73E6", VA = "0x73E6")]
		private void Awake()
		{
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002290")]
		[Address(RVA = "0x73E7", Offset = "0x73E7", VA = "0x73E7")]
		private IEnumerator DemoCoroutine()
		{
			return null;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002291")]
		[Address(RVA = "0x73E8", Offset = "0x73E8", VA = "0x73E8")]
		private void StopDemoCoroutine()
		{
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002292")]
		[Address(RVA = "0x73E9", Offset = "0x73E9", VA = "0x73E9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002293")]
		[Address(RVA = "0x73EA", Offset = "0x73EA", VA = "0x73EA")]
		private void SOnClickEvent(int index)
		{
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002294")]
		[Address(RVA = "0x73EB", Offset = "0x73EB", VA = "0x73EB")]
		private void SOnRollOutEvent(int index)
		{
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002295")]
		[Address(RVA = "0x73EC", Offset = "0x73EC", VA = "0x73EC")]
		private void SOnRollOverEvent(int index)
		{
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002296")]
		[Address(RVA = "0x73ED", Offset = "0x73ED", VA = "0x73ED")]
		private void HighlightValue(int value)
		{
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x73EE", Offset = "0x73EE", VA = "0x73EE")]
		private void SetValue(int value)
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x73EF", Offset = "0x73EF", VA = "0x73EF")]
		public RateGameComponent()
		{
		}

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RateGameStar[] _stars;

		// Token: 0x040012E1 RID: 4833
		[Token(Token = "0x40012E1")]
		[FieldOffset(Offset = "0x14")]
		private int _value;

		// Token: 0x040012E2 RID: 4834
		[Token(Token = "0x40012E2")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _demoCoroutine;
	}
}
