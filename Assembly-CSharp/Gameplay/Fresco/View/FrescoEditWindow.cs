using System;
using Core.MVC.Interfaces;
using Gameplay.Fresco.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007ED RID: 2029
	[Token(Token = "0x20007ED")]
	public class FrescoEditWindow : ClosableBaseWindow<FrescoEditWindow.FrescoEditWindowArgs>
	{
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000959")]
		public override string WindowId
		{
			[Token(Token = "0x6002FB4")]
			[Address(RVA = "0x801A", Offset = "0x801A", VA = "0x801A", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x801B", Offset = "0x801B", VA = "0x801B", Slot = "22")]
		protected override void OnShow(FrescoEditWindow.FrescoEditWindowArgs args)
		{
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x801C", Offset = "0x801C", VA = "0x801C", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x801D", Offset = "0x801D", VA = "0x801D")]
		public FrescoEditWindow()
		{
		}

		// Token: 0x04001A0E RID: 6670
		[Token(Token = "0x4001A0E")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Fresco/FrescoEditWindow";

		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FrescoEditView _view;

		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x020007EE RID: 2030
		[Token(Token = "0x20007EE")]
		public class FrescoEditWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002FB8 RID: 12216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FB8")]
			[Address(RVA = "0x801E", Offset = "0x801E", VA = "0x801E")]
			public FrescoEditWindowArgs(FrescoController controller)
			{
			}

			// Token: 0x04001A11 RID: 6673
			[Token(Token = "0x4001A11")]
			[FieldOffset(Offset = "0x18")]
			public readonly FrescoController Controller;
		}
	}
}
