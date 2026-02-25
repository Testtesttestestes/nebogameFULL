using System;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094D RID: 2381
	[Token(Token = "0x200094D")]
	public class CombatUserBalance : MonoBehaviour
	{
		// Token: 0x0600385D RID: 14429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x8814", Offset = "0x8814", VA = "0x8814")]
		private void Start()
		{
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x8815", Offset = "0x8815", VA = "0x8815")]
		public void SetBalance(ResourceSet balance)
		{
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x8816", Offset = "0x8816", VA = "0x8816")]
		public CombatUserBalance()
		{
		}

		// Token: 0x04001F33 RID: 7987
		[Token(Token = "0x4001F33")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CombatUserBalanceItem[] _balanceItems;
	}
}
