using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	public class SearchInput : MonoBehaviour
	{
		// Token: 0x140000CA RID: 202
		// (add) Token: 0x06000834 RID: 2100 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000835 RID: 2101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CA")]
		public event Action<string> InputChangedEvent
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x5BF0", Offset = "0x5BF0", VA = "0x5BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x5BF1", Offset = "0x5BF1", VA = "0x5BF1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000103")]
		public string FilterValue
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1D22", Offset = "0x1D22", VA = "0x1D22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000104")]
		public string RawValue
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x5BF2", Offset = "0x5BF2", VA = "0x5BF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x5BF3", Offset = "0x5BF3", VA = "0x5BF3")]
		private void Awake()
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x5BF4", Offset = "0x5BF4", VA = "0x5BF4")]
		public void ResetValue()
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x5BF5", Offset = "0x5BF5", VA = "0x5BF5")]
		private void OnValueChangedHandler(string arg0)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x5BF6", Offset = "0x5BF6", VA = "0x5BF6")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x5BF7", Offset = "0x5BF7", VA = "0x5BF7")]
		public SearchInput()
		{
		}

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private uint _filterMinNumSymbols;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x1C")]
		private string _currentValue;
	}
}
