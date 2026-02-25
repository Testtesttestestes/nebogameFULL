using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Assistants.Manufacture.Model;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using UnityEngine.EventSystems;

namespace Gameplay.Assistants.Manufacture.Control
{
	// Token: 0x02000CB4 RID: 3252
	[Token(Token = "0x2000CB4")]
	public class ManufactureAssistViewInAccountViewMediator : AbstractViewMediator<ManufactureAssistModel, ManufactureAssistantEvents, ManufactureAssistController, ManufactureViewInAccountView>
	{
		// Token: 0x06004F3C RID: 20284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0x9D64", Offset = "0x9D64", VA = "0x9D64")]
		public ManufactureAssistViewInAccountViewMediator(ManufactureAssistModel model, ManufactureAssistantEvents events, ManufactureAssistController controller)
		{
		}

		// Token: 0x1700101D RID: 4125
		// (set) Token: 0x06004F3D RID: 20285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101D")]
		public override ManufactureAssistantEvents Events
		{
			[Token(Token = "0x6004F3D")]
			[Address(RVA = "0x9D65", Offset = "0x9D65", VA = "0x9D65", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700101E RID: 4126
		// (set) Token: 0x06004F3E RID: 20286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101E")]
		public override ManufactureViewInAccountView View
		{
			[Token(Token = "0x6004F3E")]
			[Address(RVA = "0x9D66", Offset = "0x9D66", VA = "0x9D66", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x9D67", Offset = "0x9D67", VA = "0x9D67")]
		private void HandleAddButtonClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x9D68", Offset = "0x9D68", VA = "0x9D68")]
		private void HandleDisassembleAllButtonClickEvent()
		{
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F41")]
		[Address(RVA = "0x9D69", Offset = "0x9D69", VA = "0x9D69")]
		private void HandleDisassemblePartButtonClickEvent()
		{
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F42")]
		[Address(RVA = "0x9D6A", Offset = "0x9D6A", VA = "0x9D6A")]
		private void HandleOpenRewardsButtonClickEvent()
		{
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F43")]
		[Address(RVA = "0x9D6B", Offset = "0x9D6B", VA = "0x9D6B")]
		private void HandleDismantleSlotsChangedEvent(ArtifactInfo info)
		{
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F44")]
		[Address(RVA = "0x9D6C", Offset = "0x9D6C", VA = "0x9D6C")]
		private void HandleDismantleStatusChangedEvent()
		{
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F45")]
		[Address(RVA = "0x9D6D", Offset = "0x9D6D", VA = "0x9D6D")]
		private void HandleInfoChangedEvent()
		{
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x9D6E", Offset = "0x9D6E", VA = "0x9D6E")]
		private void HandleDropChangedEvent()
		{
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x9D6F", Offset = "0x9D6F", VA = "0x9D6F")]
		private void SetupView()
		{
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F48")]
		[Address(RVA = "0x9D70", Offset = "0x9D70", VA = "0x9D70")]
		private void ValidateDismantleControls()
		{
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x9D71", Offset = "0x9D71", VA = "0x9D71")]
		private void ShowSelectCountForDisassembleWindow(ArtifactData artifact)
		{
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x9D72", Offset = "0x9D72", VA = "0x9D72")]
		private void DisplayStartDisassembleFailReason(ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x9D73", Offset = "0x9D73", VA = "0x9D73")]
		private void HandleDisassembleFailReason(ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x9D74", Offset = "0x9D74", VA = "0x9D74")]
		private void ValidateDescription()
		{
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x9D75", Offset = "0x9D75", VA = "0x9D75")]
		private void ShowRewardsWindow()
		{
		}

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<ManufactureAssistModel.StartFailDisassembleReasons, string> StartDisassembleFailReasonLocaleKeys;
	}
}
