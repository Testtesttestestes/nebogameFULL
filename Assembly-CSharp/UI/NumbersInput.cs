using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public class NumbersInput : MonoBehaviour
	{
		// Token: 0x140000C9 RID: 201
		// (add) Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C9")]
		public event Action<int> InputChangedEvent
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x5BE9", Offset = "0x5BE9", VA = "0x5BE9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x5BEA", Offset = "0x5BEA", VA = "0x5BEA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x17000102")]
		public int CurrentValue
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x5BEB", Offset = "0x5BEB", VA = "0x5BEB")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x5BEC", Offset = "0x5BEC", VA = "0x5BEC")]
		private void Awake()
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x5BED", Offset = "0x5BED", VA = "0x5BED")]
		private void OnValueChangedHandler(string str)
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x5BEE", Offset = "0x5BEE", VA = "0x5BEE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x5BEF", Offset = "0x5BEF", VA = "0x5BEF")]
		public NumbersInput()
		{
		}

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x18")]
		private int _currentValue;
	}
}
