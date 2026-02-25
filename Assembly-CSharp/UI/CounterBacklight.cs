using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public class CounterBacklight : MonoBehaviour
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x17000101")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x5BE4", Offset = "0x5BE4", VA = "0x5BE4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x5BE5", Offset = "0x5BE5", VA = "0x5BE5")]
		public void SetIsEnabled(bool value)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1D26", Offset = "0x1D26", VA = "0x1D26")]
		public void SetText(string value)
		{
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x5BE6", Offset = "0x5BE6", VA = "0x5BE6")]
		private void Awake()
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x5BE7", Offset = "0x5BE7", VA = "0x5BE7")]
		private void OnValidate()
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x5BE8", Offset = "0x5BE8", VA = "0x5BE8")]
		public CounterBacklight()
		{
		}

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _appearEnabled;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TMP_Text _text;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _isEnabled;
	}
}
