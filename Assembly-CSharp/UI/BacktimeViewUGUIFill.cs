using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public class BacktimeViewUGUIFill : BacktimeViewUGUI
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000034C8 File Offset: 0x000016C8
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FD")]
		public uint OriginTime
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x5BCF", Offset = "0x5BCF", VA = "0x5BCF")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x5BD0", Offset = "0x5BD0", VA = "0x5BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x5BD1", Offset = "0x5BD1", VA = "0x5BD1", Slot = "4")]
		protected override void RenderValue(string text)
		{
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x5BD2", Offset = "0x5BD2", VA = "0x5BD2")]
		public BacktimeViewUGUIFill()
		{
		}

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _fill;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _reverse;
	}
}
