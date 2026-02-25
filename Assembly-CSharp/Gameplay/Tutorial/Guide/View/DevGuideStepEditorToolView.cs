using System;
using System.Globalization;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	public class DevGuideStepEditorToolView : MonoBehaviourWithStates<DevGuideStepEditorToolView.DevGuideStepEditorToolViewStates>, IDragHandler, IEventSystemHandler, IBeginDragHandler
	{
		// Token: 0x06001A4D RID: 6733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x6BE4", Offset = "0x6BE4", VA = "0x6BE4")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x6BE5", Offset = "0x6BE5", VA = "0x6BE5")]
		private void Start()
		{
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x6BE6", Offset = "0x6BE6", VA = "0x6BE6")]
		private void HandleTargetPointerOffsetYChanged(string value)
		{
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x6BE7", Offset = "0x6BE7", VA = "0x6BE7")]
		private void HandleTargetPointerOffsetXChanged(string value)
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x6BE8", Offset = "0x6BE8", VA = "0x6BE8")]
		private void HandleTargetPointerScaleXChanged(float value)
		{
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x6BE9", Offset = "0x6BE9", VA = "0x6BE9")]
		private void HandleTargetPointerScaleYChanged(float value)
		{
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x6BEA", Offset = "0x6BEA", VA = "0x6BEA")]
		private void HandleOutlineScaleChanged(float value)
		{
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x6BEB", Offset = "0x6BEB", VA = "0x6BEB")]
		private void HandleShadeAlphaChanged(float value)
		{
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x6BEC", Offset = "0x6BEC", VA = "0x6BEC")]
		private void HandleGetValuesButtonClickEvent()
		{
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049C")]
		public GuideConfig GuideConfig
		{
			[Token(Token = "0x6001A56")]
			[Address(RVA = "0x6BED", Offset = "0x6BED", VA = "0x6BED")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A57")]
			[Address(RVA = "0x6BEE", Offset = "0x6BEE", VA = "0x6BEE")]
			set
			{
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x6BEF", Offset = "0x6BEF", VA = "0x6BEF")]
		private void HandleConfigChanged()
		{
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x6BF0", Offset = "0x6BF0", VA = "0x6BF0")]
		private void FillForm()
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x6BF1", Offset = "0x6BF1", VA = "0x6BF1")]
		private void HandleGraphicPointerScaleYChanged(string value)
		{
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x6BF2", Offset = "0x6BF2", VA = "0x6BF2")]
		private void HandleGraphicPointerScaleXChanged(string value)
		{
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x6BF3", Offset = "0x6BF3", VA = "0x6BF3")]
		private void HandleGraphicPointerOffsetYChanged(string value)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x6BF4", Offset = "0x6BF4", VA = "0x6BF4")]
		private void HandleGraphicPointerOffsetXChanged(string value)
		{
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x6BF5", Offset = "0x6BF5", VA = "0x6BF5")]
		private void HandleAngleChanged(float value)
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x6BF6", Offset = "0x6BF6", VA = "0x6BF6")]
		private void HandleGraphicPointerIdChanged(int value)
		{
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x6BF7", Offset = "0x6BF7", VA = "0x6BF7")]
		private void HandleShapeToggleChanged(bool value)
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x6BF8", Offset = "0x6BF8", VA = "0x6BF8")]
		private void HandleOverlapChanged(int value)
		{
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x6BF9", Offset = "0x6BF9", VA = "0x6BF9")]
		private void HandleShapeChanged(int value)
		{
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x6BFA", Offset = "0x6BFA", VA = "0x6BFA")]
		private void HandleMessageBlockYChanged(float value)
		{
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x6BFB", Offset = "0x6BFB", VA = "0x6BFB")]
		private void HandleMessageBlockXChanged(float value)
		{
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x6BFC", Offset = "0x6BFC", VA = "0x6BFC")]
		private void BubbleMessageLayoutChanged(int value)
		{
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x6BFD", Offset = "0x6BFD", VA = "0x6BFD", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x6BFE", Offset = "0x6BFE", VA = "0x6BFE", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x6BFF", Offset = "0x6BFF", VA = "0x6BFF")]
		public DevGuideStepEditorToolView()
		{
		}

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _id;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Dropdown _aprLayout;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Slider _messageBlockY;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _messageBlockX;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Toggle _outlineToggle;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TMP_Dropdown _shape;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TMP_Dropdown _overlapType;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _shadeAlpha;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameObject _shadeAlphaRow;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _targetPointerScaleX;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Slider _targetPointerScaleY;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider _outlineScale;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TMP_InputField _targetPointerOffsetX;

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_InputField _targetPointerOffsetY;

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TMP_Dropdown _graphicPointerId;

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _angle;

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TMP_InputField _offsetX;

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TMP_InputField _offsetY;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private TMP_InputField _scaleX;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TMP_InputField _scaleY;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _getValuesButton;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_InputField _values;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x74")]
		private NumberFormatInfo _numberFormat;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x78")]
		private GuideConfig _guideConfig;

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x7C")]
		private Vector2 _p;

		// Token: 0x02000458 RID: 1112
		[Token(Token = "0x2000458")]
		public enum DevGuideStepEditorToolViewStates
		{
			// Token: 0x04000E3D RID: 3645
			[Token(Token = "0x4000E3D")]
			UNKNOWN,
			// Token: 0x04000E3E RID: 3646
			[Token(Token = "0x4000E3E")]
			EDIT,
			// Token: 0x04000E3F RID: 3647
			[Token(Token = "0x4000E3F")]
			NOT_AVAIL
		}
	}
}
