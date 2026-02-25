using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core;
using Gameplay.Tutorial.Guide.Control;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Gameplay.Tutorial.Guide.View.Components;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x02000460 RID: 1120
	[Token(Token = "0x2000460")]
	public class GuideView : MonoBehaviour
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A4")]
		public Transform GraphicPointer
		{
			[Token(Token = "0x6001A97")]
			[Address(RVA = "0x6C2A", Offset = "0x6C2A", VA = "0x6C2A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A5")]
		public ShapePointer ShapePointer
		{
			[Token(Token = "0x6001A98")]
			[Address(RVA = "0x6C2B", Offset = "0x6C2B", VA = "0x6C2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A6")]
		public DevGuideStepEditorToolView EditStepTool
		{
			[Token(Token = "0x6001A99")]
			[Address(RVA = "0x6C2C", Offset = "0x6C2C", VA = "0x6C2C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x6C2D", Offset = "0x6C2D", VA = "0x6C2D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x6C2E", Offset = "0x6C2E", VA = "0x6C2E")]
		private void Start()
		{
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x6C2F", Offset = "0x6C2F", VA = "0x6C2F")]
		private void LateUpdate()
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A7")]
		public GuideConfig Config
		{
			[Token(Token = "0x6001A9D")]
			[Address(RVA = "0x6C30", Offset = "0x6C30", VA = "0x6C30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A9E")]
			[Address(RVA = "0x6C31", Offset = "0x6C31", VA = "0x6C31")]
			private set
			{
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A8")]
		public IGuideTarget Target
		{
			[Token(Token = "0x6001A9F")]
			[Address(RVA = "0x6C32", Offset = "0x6C32", VA = "0x6C32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AA0")]
			[Address(RVA = "0x6C33", Offset = "0x6C33", VA = "0x6C33")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x6C34", Offset = "0x6C34", VA = "0x6C34")]
		public void Run([NotNull] IGuideTarget target, [NotNull] GuideConfig config)
		{
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x6C35", Offset = "0x6C35", VA = "0x6C35")]
		private void UpdateMessageBubble()
		{
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x6C36", Offset = "0x6C36", VA = "0x6C36")]
		public void Stop()
		{
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x6C37", Offset = "0x6C37", VA = "0x6C37")]
		public void HandleStepLayoutConfigChanged()
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x6C38", Offset = "0x6C38", VA = "0x6C38")]
		private void HandleConfigChanged(GuideConfig from, GuideConfig to)
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x6C39", Offset = "0x6C39", VA = "0x6C39")]
		private void HandleOverlapClickEvent()
		{
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x6C3A", Offset = "0x6C3A", VA = "0x6C3A")]
		public void Complete(GuideConfig config)
		{
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x6C3B", Offset = "0x6C3B", VA = "0x6C3B")]
		public void UpdateShapePointerDraw()
		{
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x6C3C", Offset = "0x6C3C", VA = "0x6C3C")]
		private void HandleOldRevision()
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x6C3D", Offset = "0x6C3D", VA = "0x6C3D")]
		private void HandleNewRevision()
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x6C3E", Offset = "0x6C3E", VA = "0x6C3E")]
		private void SetupGraphicPointerAngle()
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x6C3F", Offset = "0x6C3F", VA = "0x6C3F")]
		private void SetupGraphicPointerScale()
		{
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x6C40", Offset = "0x6C40", VA = "0x6C40")]
		private void SetupGraphicPointerView()
		{
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x6C41", Offset = "0x6C41", VA = "0x6C41")]
		private void GraphicPointerOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x6C42", Offset = "0x6C42", VA = "0x6C42")]
		public GuideView()
		{
		}

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ShapePointer _shapePointer;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _graphicPointer;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _graphicPointerMoveRoot;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Description _description;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MessageBubbleView _messageBubble;

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DevGuideStepEditorToolView _editStepTool;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0x28")]
		private GuideViewMediator _mediator;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x2C")]
		public Action<GuideConfig> ResolveCompleteEvent;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x30")]
		private GuideConfig _config;

		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x38")]
		private bool _isRun;
	}
}
