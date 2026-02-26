using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x02000426 RID: 1062
	[Token(Token = "0x2000426")]
	public class MessageBubbleView : MonoBehaviourWithStates<MessageBubbleView.State>
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x6ACB", Offset = "0x6ACB", VA = "0x6ACB")]
		public void SetText(string text)
		{
		/* --- GHIDRA: SetText ---
		void Gameplay_TutorialV2_View_MessageBubbleView__SetText(int param1,float *param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  float4 fVar2;
		  float4 fVar3;
		  float4 fVar4;
		  float fVar5;
		  float fVar6;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 auStack_10 [4];
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  UnityEngine_Transform___ctor(auStack_10,*(undefined4 *)(param1 + 0x20),0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x20),0);
		  fVar2 = local_4;
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x20),0);
		  fVar3 = local_4;
		  fVar5 = param2[1];
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x24),0);
		  fVar4 = local_4;
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x24),0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x24),0);
		  fVar1 = local_8;
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x20),0);
		  fVar6 = 135.0;
		  if ((float)fVar4 <= (float)fVar3 - (float)local_c * fVar5) {
		    fVar6 = (float)fVar2;
		  }
		  local_20 = CONCAT44(fVar5 * -((float)local_4 - fVar6),((float)fVar1 - (float)local_8) * *param2);
		  local_18 = local_20;
		  UnityEngine_RectTransform__get_anchoredPosition(*(undefined4 *)(param1 + 0x20),&local_20,0);
		  return;
		}
		*/

		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x6ACC", Offset = "0x6ACC", VA = "0x6ACC")]
		public void SetPosition(Vector2 normalizedPosition)
		{
		/* --- GHIDRA: SetPosition ---
		void Gameplay_TutorialV2_View_MessageBubbleView__SetPosition
		               (int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined1 local_38 [8];
		  undefined8 local_30;
		  undefined4 local_20 [4];
		  undefined4 local_10;
		  float4 local_c;
		  undefined4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a583a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MessageBubbleView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Vector3__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Vector3__get_Value__);
		    DAT_ram_00a583a7 = '\x01';
		  }
		  if (*(char *)(param2 + 0x18) != '\0') {
		    uVar3 = *(undefined4 *)(param1 + 0x20);
		    UnityEngine_InputSystem_InputControlScheme__FindControlSchemeForDevices_InputControlList_object___ReadOnlyArray_InputControlScheme__
		              (local_20,param2 + 0x18,Method_System_Nullable_Vector3__get_Value__);
		    UnityEngine_RectTransform__get_sizeDelta(uVar3,local_38,0);
		  }
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param2 + 0xc),0);
		  iVar2 = **(int **)(param1 + 0x1c);
		  fVar1 = (float)(**(code **)((ulonglong)*(uint *)(iVar2 + 0x368) * 4))
		                           (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0x36c));
		  iVar2 = *(int *)(param1 + 0x2c);
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  UnityEngine_RectTransform__set_anchoredPosition(local_20,uVar3,0);
		  local_8 = local_20[0];
		  if (fVar1 <= (float)iVar2) {
		    fVar1 = (float)iVar2;
		  }
		  local_40 = CONCAT44(fVar1,local_20[0]);
		  local_4 = (float4)fVar1;
		  UnityEngine_RectTransform__get_sizeDelta(uVar3,&local_40,0);
		  uVar3 = *(undefined4 *)(param1 + 0x28);
		  UnityEngine_RectTransform__set_anchoredPosition(local_20,uVar3,0);
		  local_c = (float4)(fVar1 * 0.5);
		  if (64.0 <= (float)local_c) {
		    local_c = 64.0;
		  }
		  local_10 = local_20[0];
		  local_48 = CONCAT44(local_c,local_20[0]);
		  UnityEngine_RectTransform__get_sizeDelta(uVar3,&local_48,0);
		  local_50 = *(undefined8 *)(param2 + 0x10);
		  local_30 = local_50;
		  Gameplay_TutorialV2_View_MessageBubbleView__SetText(param1,&local_50,&local_50);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,*(undefined4 *)(param2 + 8),
		             Method_UI_MonoBehaviourWithStates_MessageBubbleView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x6ACD", Offset = "0x6ACD", VA = "0x6ACD")]
		public void Init(MessageBubbleView.MessageBubbleViewArgs args)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_TutorialV2_View_MessageBubbleView__Init(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a583a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MessageBubbleView_State___ctor__);
		    DAT_ram_00a583a8 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_MessageBubbleView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x6ACE", Offset = "0x6ACE", VA = "0x6ACE")]
		public MessageBubbleView()
		{
		}

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _bubbleRectTransform;

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x04000D49 RID: 3401
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _tailResizer;

		// Token: 0x04000D4A RID: 3402
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _minHeight;

		// Token: 0x02000427 RID: 1063
		[Token(Token = "0x2000427")]
		public enum State
		{
			// Token: 0x04000D4C RID: 3404
			[Token(Token = "0x4000D4C")]
			DEFAULT,
			// Token: 0x04000D4D RID: 3405
			[Token(Token = "0x4000D4D")]
			LEFT,
			// Token: 0x04000D4E RID: 3406
			[Token(Token = "0x4000D4E")]
			RIGHT
		}

		// Token: 0x02000428 RID: 1064
		[Token(Token = "0x2000428")]
		[Serializable]
		public class MessageBubbleViewArgs
		{
			// Token: 0x06001930 RID: 6448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001930")]
			[Address(RVA = "0x6ACF", Offset = "0x6ACF", VA = "0x6ACF")]
			public MessageBubbleViewArgs()
			{
			}

			// Token: 0x04000D4F RID: 3407
			[Token(Token = "0x4000D4F")]
			[FieldOffset(Offset = "0x8")]
			public MessageBubbleView.State State;

			// Token: 0x04000D50 RID: 3408
			[Token(Token = "0x4000D50")]
			[FieldOffset(Offset = "0xC")]
			public string Text;

			// Token: 0x04000D51 RID: 3409
			[Token(Token = "0x4000D51")]
			[FieldOffset(Offset = "0x10")]
			public float NormalizedX;

			// Token: 0x04000D52 RID: 3410
			[Token(Token = "0x4000D52")]
			[FieldOffset(Offset = "0x14")]
			public float NormalizedY;

			// Token: 0x04000D53 RID: 3411
			[Token(Token = "0x4000D53")]
			[FieldOffset(Offset = "0x18")]
			public Vector3? Size;
		}
	}
}
