using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	[RequireComponent(typeof(TMP_InputField))]
	public class PatternTextInput : MonoBehaviour
	{
		// Token: 0x14000116 RID: 278
		// (add) Token: 0x060017E6 RID: 6118 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060017E7 RID: 6119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000116")]
		public event Action<bool> OnStatusChanged
		{
			[Token(Token = "0x60017E6")]
			[Address(RVA = "0x69A1", Offset = "0x69A1", VA = "0x69A1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60017E7")]
			[Address(RVA = "0x69A2", Offset = "0x69A2", VA = "0x69A2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000428")]
		public TMP_InputField Input
		{
			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x69A3", Offset = "0x69A3", VA = "0x69A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017EA RID: 6122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000429")]
		public string Pattern
		{
			[Token(Token = "0x60017E9")]
			[Address(RVA = "0x69A4", Offset = "0x69A4", VA = "0x69A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017EA")]
			[Address(RVA = "0x69A5", Offset = "0x69A5", VA = "0x69A5")]
			set
			{
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x69A6", Offset = "0x69A6", VA = "0x69A6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x69A7", Offset = "0x69A7", VA = "0x69A7")]
		private void Awake()
		{
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x69A8", Offset = "0x69A8", VA = "0x69A8")]
		private void HandleOnValueChanged(string value)
		{
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00005610 File Offset: 0x00003810
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042A")]
		public bool Status
		{
			[Token(Token = "0x60017EE")]
			[Address(RVA = "0x69A9", Offset = "0x69A9", VA = "0x69A9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017EF")]
			[Address(RVA = "0x69AA", Offset = "0x69AA", VA = "0x69AA")]
			set
			{
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x69AB", Offset = "0x69AB", VA = "0x69AB")]
		private char OnValidateInput(string text, int charindex, char addedchar)
		{
			return '\0';
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x69AC", Offset = "0x69AC", VA = "0x69AC", Slot = "4")]
		protected virtual bool Check(string value)
		{
			return default(bool);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x69AD", Offset = "0x69AD", VA = "0x69AD")]
		public PatternTextInput()
		{
		}

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x18")]
		private string _pattern;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x1C")]
		private Regex _regex;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x20")]
		private bool _status;
	}
}
