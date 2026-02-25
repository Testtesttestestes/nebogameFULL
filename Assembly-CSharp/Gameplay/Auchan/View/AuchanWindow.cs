using System;
using Gameplay.Auchan.Controller;
using Gameplay.Auchan.Events;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000C8C")]
	public class AuchanWindow : ClosableBaseWindow<AuchanWindow.AuchanWindowArgs>
	{
		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FDB")]
		public override string WindowId
		{
			[Token(Token = "0x6004E4C")]
			[Address(RVA = "0x9C7E", Offset = "0x9C7E", VA = "0x9C7E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x9C7F", Offset = "0x9C7F", VA = "0x9C7F", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4E")]
		[Address(RVA = "0x9C80", Offset = "0x9C80", VA = "0x9C80", Slot = "22")]
		protected override void OnShow(AuchanWindow.AuchanWindowArgs args)
		{
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x9C81", Offset = "0x9C81", VA = "0x9C81", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x9C82", Offset = "0x9C82", VA = "0x9C82")]
		private void SetupMVC()
		{
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x9C83", Offset = "0x9C83", VA = "0x9C83")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x9C84", Offset = "0x9C84", VA = "0x9C84")]
		public AuchanWindow()
		{
		}

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Auchan/AuchanWindow";

		// Token: 0x04002AC7 RID: 10951
		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private AuchanView _auchanView;

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _auchanTitle;

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x48")]
		private AuchanModel _model;

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0x4C")]
		private AuchanEvents _events;

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		[FieldOffset(Offset = "0x50")]
		private AuchanController _controller;

		// Token: 0x04002ACD RID: 10957
		[Token(Token = "0x4002ACD")]
		[FieldOffset(Offset = "0x54")]
		private AuchanViewMediator _mediator;

		// Token: 0x04002ACE RID: 10958
		[Token(Token = "0x4002ACE")]
		[FieldOffset(Offset = "0x58")]
		private bool _mvcSetUp;

		// Token: 0x02000C8D RID: 3213
		[Token(Token = "0x2000C8D")]
		public class AuchanWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004E53 RID: 20051 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E53")]
			[Address(RVA = "0x9C85", Offset = "0x9C85", VA = "0x9C85")]
			public AuchanWindowArgs()
			{
			}
		}
	}
}
