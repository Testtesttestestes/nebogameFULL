using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace UI.Localization
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LocalizationTextField : BaseMonoBehaviour
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000199")]
		private TextMeshProUGUI TextField
		{
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x5F5F", Offset = "0x5F5F", VA = "0x5F5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x5F60", Offset = "0x5F60", VA = "0x5F60")]
		private void Awake()
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x5F61", Offset = "0x5F61", VA = "0x5F61")]
		private void Localize()
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x5F62", Offset = "0x5F62", VA = "0x5F62")]
		public LocalizationTextField()
		{
		}

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _key;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<string> _terms;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI _textField;
	}
}
