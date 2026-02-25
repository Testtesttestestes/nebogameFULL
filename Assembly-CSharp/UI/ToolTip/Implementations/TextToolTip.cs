using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public class TextToolTip : ToolTip, IToolTipDataProvider
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x5CF6", Offset = "0x5CF6", VA = "0x5CF6", Slot = "9")]
		public override void Dispose()
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		public string Text
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x5CF7", Offset = "0x5CF7", VA = "0x5CF7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x5CF8", Offset = "0x5CF8", VA = "0x5CF8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000146")]
		public IToolTipDataProvider DataProvider
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x5CF9", Offset = "0x5CF9", VA = "0x5CF9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x5CFA", Offset = "0x5CFA", VA = "0x5CFA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x5CFB", Offset = "0x5CFB", VA = "0x5CFB", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x5CFC", Offset = "0x5CFC", VA = "0x5CFC")]
		public void SetMinSize(in Vector2 value)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x5CFD", Offset = "0x5CFD", VA = "0x5CFD")]
		public void SetMaxSize(in Vector2 value)
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x5CFE", Offset = "0x5CFE", VA = "0x5CFE")]
		private BaseToolTipData FillSizes(BaseToolTipData data)
		{
			return null;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x5CFF", Offset = "0x5CFF", VA = "0x5CFF")]
		public TextToolTip()
		{
		}

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 _minSize;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _maxSize;
	}
}
