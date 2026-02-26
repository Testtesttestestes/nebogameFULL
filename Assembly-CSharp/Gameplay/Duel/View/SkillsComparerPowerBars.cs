using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085F RID: 2143
	[Token(Token = "0x200085F")]
	public class SkillsComparerPowerBars : MonoBehaviour
	{
		// Token: 0x06003252 RID: 12882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003252")]
		[Address(RVA = "0x82A7", Offset = "0x82A7", VA = "0x82A7")]
		public void Init(float leftValue, float rightValue)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Duel_View_SkillsComparerPowerBars__Init
		               (int param1,undefined4 param2,float param3,undefined4 param4)
		
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
		  
		  if (DAT_ram_00a57bd5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    DAT_ram_00a57bd5 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x34);
		  iVar3 = *(int *)(param1 + 0x38);
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

		// Token: 0x06003253 RID: 12883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003253")]
		[Address(RVA = "0x82A8", Offset = "0x82A8", VA = "0x82A8")]
		private void SetBarValue(Image bar, float percent)
		{
		/* --- GHIDRA: SetBarValue ---
		void Gameplay_Duel_View_SkillsComparerPowerBars__SetBarValue
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  func_ii_7050(*(undefined4 *)(param1 + 0x18),param2,0);
		  func_ii_7050(*(undefined4 *)(param1 + 0x1c),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003254")]
		[Address(RVA = "0x82A9", Offset = "0x82A9", VA = "0x82A9")]
		private void AssignSprites(Sprite left, Sprite right)
		{
		/* --- GHIDRA: AssignSprites ---
		void Gameplay_Duel_View_SkillsComparerPowerBars__AssignSprites
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  func_ii_7050(*(undefined4 *)(param1 + 0x10),param2,0);
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003255")]
		[Address(RVA = "0x82AA", Offset = "0x82AA", VA = "0x82AA")]
		private void AssignBarSprites(Sprite left, Sprite right)
		{
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003256")]
		[Address(RVA = "0x82AB", Offset = "0x82AB", VA = "0x82AB")]
		public SkillsComparerPowerBars()
		{
		}

		// Token: 0x04001B8F RID: 7055
		[Token(Token = "0x4001B8F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _leftBar;

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _rightBar;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _leftIcon;

		// Token: 0x04001B92 RID: 7058
		[Token(Token = "0x4001B92")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _rightIcon;

		// Token: 0x04001B93 RID: 7059
		[Token(Token = "0x4001B93")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _barGreenSprite;

		// Token: 0x04001B94 RID: 7060
		[Token(Token = "0x4001B94")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _barRedSprite;

		// Token: 0x04001B95 RID: 7061
		[Token(Token = "0x4001B95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _greaterIconSprite;

		// Token: 0x04001B96 RID: 7062
		[Token(Token = "0x4001B96")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _lessIconSprite;

		// Token: 0x04001B97 RID: 7063
		[Token(Token = "0x4001B97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _equalsIconSprite;

		// Token: 0x04001B98 RID: 7064
		[Token(Token = "0x4001B98")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _minBarSize;

		// Token: 0x04001B99 RID: 7065
		[Token(Token = "0x4001B99")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _maxBarSize;
	}
}
