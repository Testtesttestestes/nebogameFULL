using System;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;

namespace UI.Elements.RightPanel
{
	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	public class TitleWithLevel : MonoBehaviour
	{
		// Token: 0x170001B6 RID: 438
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		public string Title
		{
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x1B52", Offset = "0x1B52", VA = "0x1B52")]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B7")]
		public uint Level
		{
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x1B53", Offset = "0x1B53", VA = "0x1B53")]
			set
			{
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x6006", Offset = "0x6006", VA = "0x6006")]
		public void Init(TitleWithLevelArgs args)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x6007", Offset = "0x6007", VA = "0x6007")]
		public TitleWithLevel()
		{
		}

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelCounter _levelCounter;
	}
}
