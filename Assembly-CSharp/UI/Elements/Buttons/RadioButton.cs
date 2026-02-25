using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Buttons
{
	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	[RequireComponent(typeof(Toggle))]
	public class RadioButton : MonoBehaviour
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E5")]
		public Toggle Toggle
		{
			[Token(Token = "0x6000E33")]
			[Address(RVA = "0x60C5", Offset = "0x60C5", VA = "0x60C5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E6")]
		public string Title
		{
			[Token(Token = "0x6000E34")]
			[Address(RVA = "0x60C6", Offset = "0x60C6", VA = "0x60C6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E35")]
			[Address(RVA = "0x1F2D", Offset = "0x1F2D", VA = "0x1F2D")]
			set
			{
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E7")]
		public virtual object Data
		{
			[Token(Token = "0x6000E36")]
			[Address(RVA = "0x60C7", Offset = "0x60C7", VA = "0x60C7", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E37")]
			[Address(RVA = "0x60C8", Offset = "0x60C8", VA = "0x60C8", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x60C9", Offset = "0x60C9", VA = "0x60C9")]
		public RadioButton()
		{
		}

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _titleField;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _toggle;
	}
}
