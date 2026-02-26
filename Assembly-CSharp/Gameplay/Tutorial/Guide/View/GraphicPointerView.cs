using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	public class GraphicPointerView : MonoBehaviour
	{
		// Token: 0x06001A70 RID: 6768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x6C07", Offset = "0x6C07", VA = "0x6C07")]
		public void SetGraphicPointer(string assetId)
		{
		/* --- GHIDRA: SetGraphicPointer ---
		void Gameplay_Tutorial_Guide_View_GraphicPointerView__SetGraphicPointer
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  float local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  float4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x10),0);
		  local_20 = param2 * 0.017453292;
		  local_28 = 0;
		  local_c = 0;
		  local_4 = (float4)local_20;
		  UnityEngine_Quaternion__Lerp(&local_1c,&local_28,0);
		  local_30 = local_14;
		  local_38 = local_1c;
		  UnityEngine_Transform__get_localRotation(param1_00,&local_38,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x6C08", Offset = "0x6C08", VA = "0x6C08")]
		public void SetRotation(float angle)
		{
		/* --- GHIDRA: SetRotation ---
		void Gameplay_Tutorial_Guide_View_GraphicPointerView__SetRotation
		               (int param1,undefined4 param2,float *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined8 local_28;
		  float local_20;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x10),0);
		  func_ii_7888(&local_c,param2,0);
		  local_20 = (float)local_4 + param3[2];
		  local_14 = (float4)((float)local_8 + param3[1]);
		  local_18 = (float4)((float)local_c + *param3);
		  local_28 = CONCAT44(local_14,local_18);
		  local_10 = (float4)local_20;
		  UnityEngine_Transform__get_position(param1_00,&local_28,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x6C09", Offset = "0x6C09", VA = "0x6C09")]
		public void SetPositionOffset(RectTransform rectTransform, Vector3 offset)
		{
		/* --- GHIDRA: SetPositionOffset ---
		void Gameplay_Tutorial_Guide_View_GraphicPointerView__SetPositionOffset
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58441 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo);
		    DAT_ram_00a58441 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  *(undefined1 *)(param1_00 + 0x45) = (undefined1)param3;
		  local_8 = 0xffffffff;
		  local_c = Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo;
		  local_4 = param2;
		  param2_00 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  AssetContent_GameAnimationView__OnDestroy(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x6C0A", Offset = "0x6C0A", VA = "0x6C0A")]
		public void PlayAnimation(GraphicPointerView.Animation animation, bool loop = true)
		{
		/* --- GHIDRA: PlayAnimation ---
		void Gameplay_Tutorial_Guide_View_GraphicPointerView__PlayAnimation
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x10),0);
		  local_18 = *param2;
		  local_4 = 0;
		  local_10 = 0;
		  local_c = local_18;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(param1_00,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x6C0B", Offset = "0x6C0B", VA = "0x6C0B")]
		public void SetPosition(Vector2 position)
		{
		/* --- GHIDRA: SetPosition ---
		void Gameplay_Tutorial_Guide_View_GraphicPointerView__SetPosition
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  int param1_00;
		  undefined8 uVar3;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  float local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 uStack_10;
		  undefined8 local_c;
		  float4 local_4;
		  
		  uVar3 = *(undefined8 *)(param2 + 0xc);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  local_14 = 0;
		  local_20 = 0;
		  local_28 = uVar3;
		  local_1c = uVar3;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar1,&local_28,0);
		  fVar2 = *(float *)(param2 + 0x14);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  local_30 = fVar2 * 0.017453292;
		  local_38 = 0;
		  local_c = 0;
		  local_4 = (float4)local_30;
		  UnityEngine_Quaternion__Lerp(&local_1c,&local_38,0);
		  local_40 = CONCAT44(uStack_10,local_14);
		  local_48 = local_1c;
		  UnityEngine_Transform__get_localRotation(uVar1,&local_48,0);
		  uVar1 = *(undefined4 *)(param2 + 8);
		  if (DAT_ram_00a58441 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo);
		    DAT_ram_00a58441 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  *(undefined1 *)(param1_00 + 0x45) = 1;
		  local_1c = CONCAT44(0xffffffff,Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo)
		  ;
		  local_14 = uVar1;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		  AssetContent_GameAnimationView__OnDestroy(param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x6C0C", Offset = "0x6C0C", VA = "0x6C0C")]
		public void Init(GraphicPointerView.GraphicPointerViewArgs args)
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x6C0D", Offset = "0x6C0D", VA = "0x6C0D")]
		public GraphicPointerView()
		{
		}

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x0200045B RID: 1115
		[Token(Token = "0x200045B")]
		public enum Animation
		{
			// Token: 0x04000E44 RID: 3652
			[Token(Token = "0x4000E44")]
			click,
			// Token: 0x04000E45 RID: 3653
			[Token(Token = "0x4000E45")]
			double_click,
			// Token: 0x04000E46 RID: 3654
			[Token(Token = "0x4000E46")]
			long_click,
			// Token: 0x04000E47 RID: 3655
			[Token(Token = "0x4000E47")]
			swipe_down,
			// Token: 0x04000E48 RID: 3656
			[Token(Token = "0x4000E48")]
			swipe_left,
			// Token: 0x04000E49 RID: 3657
			[Token(Token = "0x4000E49")]
			swipe_right,
			// Token: 0x04000E4A RID: 3658
			[Token(Token = "0x4000E4A")]
			swipe_up
		}

		// Token: 0x0200045C RID: 1116
		[Token(Token = "0x200045C")]
		public class GraphicPointerViewArgs
		{
			// Token: 0x06001A77 RID: 6775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001A77")]
			[Address(RVA = "0x6C0E", Offset = "0x6C0E", VA = "0x6C0E")]
			public GraphicPointerViewArgs()
			{
			}

			// Token: 0x04000E4B RID: 3659
			[Token(Token = "0x4000E4B")]
			[FieldOffset(Offset = "0x8")]
			public GraphicPointerView.Animation Animation;

			// Token: 0x04000E4C RID: 3660
			[Token(Token = "0x4000E4C")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 Position;

			// Token: 0x04000E4D RID: 3661
			[Token(Token = "0x4000E4D")]
			[FieldOffset(Offset = "0x14")]
			public float Angle;
		}
	}
}
