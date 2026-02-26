using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	public class ResourceBarDeltaView : ResourceBarIconValueView
	{
		// Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x71F3", Offset = "0x71F3", VA = "0x71F3")]
		public void ShowAnimation(ResourceBarItemView.ResourceDeltaData deltaData, float duration, Action<ResourceBarDeltaView> completeCallback)
		{
		/* --- GHIDRA: ShowAnimation ---
		void Gameplay_ResourceBar_View_ResourceBarDeltaView__ShowAnimation(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 param2_01;
		  undefined1 local_38 [8];
		  float4 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  undefined4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x34),0);
		  param2_00 = TMPro_TMP_Text__get_transform(*(undefined4 *)(param1 + 0x14),0);
		  param2_01 = TMPro_TMP_Text__get_transform(*(undefined4 *)(param1 + 0x14),0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,param2_01,0);
		  local_14 = 0;
		  local_20 = 0;
		  local_18 = (float4)((float)local_c + (float)local_4 * 0.5);
		  local_1c = (float4)((float)local_10 + (float)local_8 * 0.5);
		  local_28 = CONCAT44(local_18,local_1c);
		  UnityEngine_Transform__TransformVector(&local_10,param2_00,&local_28,0);
		  local_30 = local_8;
		  UnityEngine_Transform__get_position(uVar1,local_38,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x71F4", Offset = "0x71F4", VA = "0x71F4")]
		private void SetupCloud()
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x71F5", Offset = "0x71F5", VA = "0x71F5")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_ResourceBar_View_ResourceBarDeltaView__OnDestroy(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x3c),0);
		  return;
		}
		*/

		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x71F6", Offset = "0x71F6", VA = "0x71F6")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		void Gameplay_ResourceBar_View_ResourceBarDeltaView__Reset(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58325 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a58325 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x3c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x71F7", Offset = "0x71F7", VA = "0x71F7")]
		public ResourceBarDeltaView()
		{
		}

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _cloud;

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x38")]
		private ResourceBarItemView.ResourceDeltaData _deltaData;

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x3C")]
		private TweenContainer _tweenContainer;
	}
}
