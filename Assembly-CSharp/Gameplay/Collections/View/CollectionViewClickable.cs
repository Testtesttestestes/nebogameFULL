using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C9 RID: 2505
	[Token(Token = "0x20009C9")]
	public class CollectionViewClickable : CollectionView
	{
		// Token: 0x06003C06 RID: 15366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C06")]
		[Address(RVA = "0x8AD5", Offset = "0x8AD5", VA = "0x8AD5")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Collections_View_CollectionViewClickable__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57e8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionViewClickable_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57e8f = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Collections_View_CollectionViewClickable_ButtonClickedEventHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C07")]
		[Address(RVA = "0x8AD6", Offset = "0x8AD6", VA = "0x8AD6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Collections_View_CollectionViewClickable__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57e90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57e90 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x280);
		        goto code_r0x80e7371c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x80e7371c:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param2_00 = System_Linq_Enumerable__FirstOrDefault_uint_
		                        (*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x28),0);
		  Core_Gameplay_Managers_CollectionsManager__ShowCollectionsWindow
		            (param1_00,param2_00,*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C08")]
		[Address(RVA = "0x8AD7", Offset = "0x8AD7", VA = "0x8AD7")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C09")]
		[Address(RVA = "0x8AD8", Offset = "0x8AD8", VA = "0x8AD8")]
		public CollectionViewClickable()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_View_CollectionViewClickable___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e91 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponentInChildren_Mask___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CollectionsViewsHolder__Start__
		              );
		    DAT_ram_00a57e91 = '\x01';
		  }
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (param1,Method_UnityEngine_Component_GetComponentInChildren_Mask___);
		  *(undefined4 *)(param1 + 0xa4) = uVar1;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CollectionsViewsHolder__Start__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002122 RID: 8482
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _button;
	}
}
