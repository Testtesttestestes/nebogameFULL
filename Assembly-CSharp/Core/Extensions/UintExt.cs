using System;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F12 RID: 3858
	[Token(Token = "0x2000F12")]
	public static class UintExt
	{
		// Token: 0x06005D41 RID: 23873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D41")]
		[Address(RVA = "0xA9B6", Offset = "0xA9B6", VA = "0xA9B6")]
		public static void SetFlag(this uint value, uint flag)
		{
		/* --- GHIDRA: SetFlag ---
		void Core_Extensions_UintExt__SetFlag(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5ace0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_UriExt___c_TypeInfo);
		    DAT_ram_00a5ace0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Extensions_UriExt___c_TypeInfo);
		  **(undefined4 **)(Core_Extensions_UriExt___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x00010D10 File Offset: 0x0000EF10
		[Token(Token = "0x6005D42")]
		[Address(RVA = "0x1E0F", Offset = "0x1E0F", VA = "0x1E0F")]
		public static bool IsSetFlag(this uint value, uint flag)
		{
		/* --- GHIDRA: IsSetFlag ---
		void Core_Extensions_UintExt__IsSetFlag
		               (int *param1,undefined4 param2,int param3,int param4,undefined8 *param5,
		               undefined4 param6)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  int iVar3;
		  undefined4 uVar4;
		  float fVar5;
		  undefined8 uVar6;
		  undefined8 local_18;
		  float local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a58d4f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleBonusView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleBonusesView_SpriteLoaderOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_IsleBonusView__Get__);
		    DAT_ram_00a58d4f = '\x01';
		  }
		  uVar2 = Gameplay_Isles_User_View_IsleBonusesView__remove_BonusClickedEvent(param1,0);
		  param1_01 = Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                        (uVar2,Method_Utils_Cache_ObjectPool_IsleBonusView__Get__);
		  uVar2 = unnamed_function_1417(System_Action_IsleBonusView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Isles_User_View_IsleBonusesView_SpriteLoaderOnClickEvent__
		             ,0);
		  if (DAT_ram_00a58d47 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleBonusView__TypeInfo);
		    DAT_ram_00a58d47 = '\x01';
		  }
		  param1_00 = *(int *)(param1_01 + 0x24);
		  while( true ) {
		    iVar3 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		    uVar4 = System_Action_IsleBonusView__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar3 = func_ii_1082(param1_02,System_Action_IsleBonusView__TypeInfo), iVar3 == 0)) break;
		    iVar3 = func_ii_4329(param1_01 + 0x24,iVar3,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      *(undefined4 *)(param1_01 + 0x18) = *(undefined4 *)(param4 + 0xc);
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_01,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		                (param1[0xc],param2,param1_01,
		                 Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__Add__);
		      if (param3 == 1) {
		        uVar4 = *(undefined4 *)(param1_01 + 0x14);
		        uVar2 = Core_Extensions_Dict_TournamentDicExt__GetBannerAssetId(param4,0);
		        AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId(uVar4,uVar2,0);
		      }
		      else if (param3 == 2) {
		        uVar4 = *(undefined4 *)(param1_01 + 0x14);
		        uVar2 = Core_Extensions_Dict_TreeBonusAnimationExt__GetCrystalAssetId(param4,0);
		        AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId(uVar4,uVar2,0);
		      }
		      else if (param3 == 3) {
		        uVar4 = *(undefined4 *)(param1_01 + 0x14);
		        uVar2 = Core_Extensions_Dict_TreeBonusAnimationExt__GetDiamondsAssetId(param4,0);
		        AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId(uVar4,uVar2,0);
		      }
		      uVar6 = *param5;
		      fVar5 = *(float *)(param1_01 + 0x10);
		      uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1_01,0);
		      local_10 = fVar5 * 0.0 + 0.0;
		      local_c = (float4)(fVar5 + (float)uVar6);
		      local_8 = (float4)(-fVar5 - (float)((ulonglong)uVar6 >> 0x20));
		      local_18 = CONCAT44(local_8,local_c);
		      local_4 = (float4)local_10;
		      Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar2,&local_18,0);
		      if (DAT_ram_00a58d41 == '\0') {
		        Mono_Security_ASN1__get_Item(&StringLiteral_3948);
		        DAT_ram_00a58d41 = '\x01';
		      }
		      *(undefined4 *)(param1_01 + 0x1c) = param2;
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_01,0);
		      uVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(param1_01 + 0x1c,0);
		      uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3948,uVar4,0);
		      UnityEngine_Texture2D___ctor(uVar2,uVar4,0);
		      func_ii_7672(*(undefined4 *)(param1_01 + 0x14),1,0);
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                (param1,*(undefined4 *)(*param1 + 0x10c));
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}
	}
}
