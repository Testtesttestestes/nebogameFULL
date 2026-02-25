using System;
using Gameplay.Isles.Base.View;
using Gameplay.Isles.User.Controller;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D21 RID: 3361
	[Token(Token = "0x2000D21")]
	public class UserIsleView : BaseIsleView, IToolTipDataProvider
	{
		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600521F RID: 21023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B1")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x600521F")]
			[Address(RVA = "0x9FF6", Offset = "0x9FF6", VA = "0x9FF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B2")]
		public IsleAccountMarkersLayerView IsleAccountMarkersLayer
		{
			[Token(Token = "0x6005220")]
			[Address(RVA = "0x9FF7", Offset = "0x9FF7", VA = "0x9FF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B3")]
		public IsleAnimationsView IsleAnimationsView
		{
			[Token(Token = "0x6005221")]
			[Address(RVA = "0x9FF8", Offset = "0x9FF8", VA = "0x9FF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B4")]
		public IsleBonusesView IsleBonusesView
		{
			[Token(Token = "0x6005222")]
			[Address(RVA = "0x9FF9", Offset = "0x9FF9", VA = "0x9FF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06005223 RID: 21027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B5")]
		public IsleDecorationsView IsleDecorationsView
		{
			[Token(Token = "0x6005223")]
			[Address(RVA = "0x9FFA", Offset = "0x9FFA", VA = "0x9FFA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005224")]
		[Address(RVA = "0x9FFB", Offset = "0x9FFB", VA = "0x9FFB")]
		public void Init(UserIsle isle)
		{
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005225")]
		[Address(RVA = "0x9FFC", Offset = "0x9FFC", VA = "0x9FFC")]
		public void Deinit()
		{
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005226")]
		[Address(RVA = "0x9FFD", Offset = "0x9FFD", VA = "0x9FFD", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005227")]
		[Address(RVA = "0x9FFE", Offset = "0x9FFE", VA = "0x9FFE")]
		public UserIsleView()
		{
		}

		// Token: 0x04002CA8 RID: 11432
		[Token(Token = "0x4002CA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private IsleBonusesView _isleBonusesView;

		// Token: 0x04002CA9 RID: 11433
		[Token(Token = "0x4002CA9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private IsleDecorationsView _isleDecorationsView;

		// Token: 0x04002CAA RID: 11434
		[Token(Token = "0x4002CAA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IsleAnimationsView _isleAnimationsView;

		// Token: 0x04002CAB RID: 11435
		[Token(Token = "0x4002CAB")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private IsleAccountMarkersLayerView _isleAccountMarkersLayer;

		// Token: 0x04002CAC RID: 11436
		[Token(Token = "0x4002CAC")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		[FieldOffset(Offset = "0x4C")]
		private UserIsleViewMediator _mediator;
	}
}
