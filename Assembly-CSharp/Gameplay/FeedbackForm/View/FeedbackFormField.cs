using System;
using Gameplay.FeedbackForm.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.FeedbackForm.View
{
	// Token: 0x02000814 RID: 2068
	[Token(Token = "0x2000814")]
	public class FeedbackFormField : MonoBehaviour
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x17000980")]
		public FormFields FormField
		{
			[Token(Token = "0x60030C3")]
			[Address(RVA = "0x8128", Offset = "0x8128", VA = "0x8128")]
			get
			{
				return (FormFields)0;
			}
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x8129", Offset = "0x8129", VA = "0x8129")]
		public FeedbackFormField()
		{
		}

		// Token: 0x04001A95 RID: 6805
		[Token(Token = "0x4001A95")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FormFields _formField;
	}
}
