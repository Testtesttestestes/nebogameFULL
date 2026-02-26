using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001308 RID: 4872
	[Token(Token = "0x2001308")]
	public abstract class SpriteCloudWorldObjectArgs : WorldObjectArgs
	{
		// Token: 0x060073DE RID: 29662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DE")]
		[Address(RVA = "0xBDC1", Offset = "0xBDC1", VA = "0xBDC1")]
		protected SpriteCloudWorldObjectArgs(Vector3 position, Func<float, float, float> randomRange, Sprite sprite, float cloudDistance, float cloudStepDistance)
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_SpriteCloudWorldObjectArgs___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 *puVar3;
		  int param1_01;
		  undefined4 param2_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59696 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_BaseIsleBuildingView__GameAssetViewSpriteRenderer___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_BaseIsleBuildingView__GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_UserIsleWorldObject___c__HandleDataChanged_b__5_0__);
		    Mono_Security_ASN1__get_Item(&CloudsFly_UserIsleWorldObject___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_UserIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_WorldObject_IsleCloudObjectArgs__get_Args__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17351);
		    DAT_ram_00a59696 = '\x01';
		  }
		  CloudsFly_BaseIsleWorldObject__OnInit(param1,0);
		  param1_00 = *(int **)(param1[9] + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Isles_User_UserIsle_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Isles_User_UserIsle_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Isles_User_UserIsle_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Isles_User_UserIsle_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  local_8 = *(undefined8 *)(param1_00 + 6);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar2 = func_ii_4419(StringLiteral_17351,uVar2,0);
		  UnityEngine_Texture2D___ctor(uVar1,uVar2,0);
		  Gameplay_Isles_User_View_UserIsleView__get_IsleDecorationsView(param1[0x11],param1_00,0);
		  uVar2 = *(undefined4 *)(param1[0x13] + 0x38);
		  uVar1 = func_ii_12328(param1[0x11],0);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (uVar1,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Values__
		                    );
		  if (*(int *)(CloudsFly_UserIsleWorldObject___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(CloudsFly_UserIsleWorldObject___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(CloudsFly_UserIsleWorldObject___c_TypeInfo + 0x5c);
		  param1_01 = puVar3[1];
		  if (param1_01 == 0) {
		    if (*(int *)(CloudsFly_UserIsleWorldObject___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(CloudsFly_UserIsleWorldObject___c_TypeInfo);
		      puVar3 = *(undefined4 **)(CloudsFly_UserIsleWorldObject___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar3;
		    param1_01 = unnamed_function_1417
		                          (System_Func_BaseIsleBuildingView__GameAssetViewSpriteRenderer__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_01,param2_00,
		               Method_CloudsFly_UserIsleWorldObject___c__HandleDataChanged_b__5_0__,0);
		    *(int *)(*(int *)(CloudsFly_UserIsleWorldObject___c_TypeInfo + 0x5c) + 4) = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_01,
		                     Method_System_Linq_Enumerable_Select_BaseIsleBuildingView__GameAssetViewSpriteRenderer___
		                    );
		  Utils_Trackers_AsyncLoadableContentTracker__get_IsReady(uVar2,uVar1,0);
		  Gameplay_Isles_User_View_Monster_IsleMonsterView__ApplySortingOrder(param1[0x13],param1_00,0);
		  Gameplay_Portals_View_PortalsEntryPointView__ApplySortingLayerId(param1[0x12],param1_00,0);
		  Gameplay_Isles_Base_View_BaseIsleView___ctor(param1[0xc],param1_00,param1_00[3],0);
		  Gameplay_Isles_User_View_BackClanIsleView__BgOnClickEvent(param1[0x14],param1_00,0);
		  Gameplay_Isles_User_View_ColossusOnUserIsleView__get_ColossusView(param1[0x15],param1_00,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  return;
		}
		*/

		}

		// Token: 0x04003CAE RID: 15534
		[Token(Token = "0x4003CAE")]
		[FieldOffset(Offset = "0x18")]
		public readonly Sprite Sprite;

		// Token: 0x04003CAF RID: 15535
		[Token(Token = "0x4003CAF")]
		[FieldOffset(Offset = "0x1C")]
		public readonly float CloudDistance;

		// Token: 0x04003CB0 RID: 15536
		[Token(Token = "0x4003CB0")]
		[FieldOffset(Offset = "0x20")]
		public readonly float CloudStepDistance;
	}
}
