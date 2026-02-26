using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD4 RID: 3284
	[Token(Token = "0x2000CD4")]
	public class ArtifactComparerPowerBars : MonoBehaviour
	{
		// Token: 0x06004FF0 RID: 20464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x9E04", Offset = "0x9E04", VA = "0x9E04")]
		public void SetData(ArtifactData targetArtifact, ArtifactData comparableArtifact, bool showDebugInfo)
		{
		/* --- GHIDRA: <SetData>g__SetBarValue|13_0 ---
		/* WARNING: Type propagation algorithm not settling */
		
		void Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___SetData_g__SetBarValue_13_0
		               (undefined4 param1,int *param2,int param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a05 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2640);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2641);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2639);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2642);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    Mono_Security_ASN1__get_Item(&StringLiteral_149);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a58a05 = '\x01';
		  }
		  local_8 = 0;
		  if (param3 == 0) {
		    return;
		  }
		  if (*(int *)(param3 + 0x80) == 1) {
		    iVar6 = *(int *)(param3 + 0x70);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x80f5d8d5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f5d8d5:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar5 = func_ii_7112(uVar4,0);
		    if (iVar5 == iVar6) {
		      iVar6 = Gameplay_Inventory_Model_ArtifactDataUtils__IsInBag(param3,0);
		      if (iVar6 == 0) {
		        puVar2 = (undefined4 *)&StringLiteral_2641;
		        iVar6 = Gameplay_Inventory_Model_ArtifactDataUtils__IsInChest(param3,0);
		        if (iVar6 == 0) {
		          puVar2 = &StringLiteral_2642;
		        }
		        iVar6 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      else {
		        puVar2 = &StringLiteral_2640;
		        iVar6 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      goto joined_r0x80f5d910;
		    }
		  }
		  puVar2 = &StringLiteral_2639;
		  iVar6 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		joined_r0x80f5d910:
		  if (iVar6 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar2,1,0,1,0,0,0,0);
		  if (*(char *)(param4 + 4) != '\0') {
		    local_8 = *(undefined8 *)(param3 + 0x60);
		    param3_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar4 = System_Int32__ToString(uVar4,StringLiteral_149,param3_00,StringLiteral_1145,0);
		  }
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x2d0) * 4))
		            (param2,uVar4,*(undefined4 *)(*param2 + 0x2d4));
		  return;
		}
		*/

		/* --- GHIDRA: SetData ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars__SetData(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UnityEngine_UI_Graphic__get_depth(*(undefined4 *)(param1 + 0x10),0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = UnityEngine_UI_Graphic__get_depth(*(undefined4 *)(param1 + 0x14),0);
		  func_ii_8007(uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF1")]
		[Address(RVA = "0x9E05", Offset = "0x9E05", VA = "0x9E05")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF2")]
		[Address(RVA = "0x9E06", Offset = "0x9E06", VA = "0x9E06")]
		public ArtifactComparerPowerBars()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___ctor
		               (int param1,undefined4 param2,float param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int iVar3;
		  undefined8 local_18;
		  float4 local_10;
		  undefined4 local_c;
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58a04 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    DAT_ram_00a58a04 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x3c);
		  iVar3 = *(int *)(param1 + 0x40);
		  uVar1 = UnityEngine_UI_Graphic__get_depth(param2,0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = UnityEngine_UI_Graphic__get_depth(param2,0);
		  param2_00 = UnityEngine_UI_Graphic__get_depth(param2,0);
		  UnityEngine_RectTransform__set_anchoredPosition(auStack_8,param2_00,0);
		  local_10 = (float4)((float)(iVar3 - iVar2) * param3 + (float)iVar2);
		  local_c = local_4;
		  local_18 = CONCAT44(local_4,local_10);
		  uVar1 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar1,&local_18,0.5,0,0);
		  DG_Tweening_ShortcutExtensions__DOScale
		            (uVar1,6,
		             Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF3")]
		[Address(RVA = "0x9E07", Offset = "0x9E07", VA = "0x9E07")]
		[CompilerGenerated]
		private void <SetData>g__SetBarValue|13_0(Image bar, float percent, ref ArtifactComparerPowerBars.<>c__DisplayClass13_0 A_3)
		{
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF4")]
		[Address(RVA = "0x9E08", Offset = "0x9E08", VA = "0x9E08")]
		[CompilerGenerated]
		private void <SetData>g__SetTitle|13_1(TextMeshProUGUI label, ArtifactData artifact, ref ArtifactComparerPowerBars.<>c__DisplayClass13_0 A_3)
		{
		}

		// Token: 0x04002B7F RID: 11135
		[Token(Token = "0x4002B7F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _barLeft;

		// Token: 0x04002B80 RID: 11136
		[Token(Token = "0x4002B80")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _barRight;

		// Token: 0x04002B81 RID: 11137
		[Token(Token = "0x4002B81")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _leftIcon;

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _rightIcon;

		// Token: 0x04002B83 RID: 11139
		[Token(Token = "0x4002B83")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _leftTitle;

		// Token: 0x04002B84 RID: 11140
		[Token(Token = "0x4002B84")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _rightTitle;

		// Token: 0x04002B85 RID: 11141
		[Token(Token = "0x4002B85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _barGreenSprite;

		// Token: 0x04002B86 RID: 11142
		[Token(Token = "0x4002B86")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _barRedSprite;

		// Token: 0x04002B87 RID: 11143
		[Token(Token = "0x4002B87")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _greaterIconSprite;

		// Token: 0x04002B88 RID: 11144
		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _lessIconSprite;

		// Token: 0x04002B89 RID: 11145
		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _equalsIconSprite;

		// Token: 0x04002B8A RID: 11146
		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _minBarSize;

		// Token: 0x04002B8B RID: 11147
		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _maxBarSize;
	}
}
