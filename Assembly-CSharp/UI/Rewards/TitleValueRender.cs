using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	public class TitleValueRender : MonoBehaviour
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x5E83", Offset = "0x5E83", VA = "0x5E83")]
		public void Init(string title, string value)
		{
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x5E84", Offset = "0x5E84", VA = "0x5E84")]
		public TitleValueRender()
		{
		}

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _value;
	}
}
