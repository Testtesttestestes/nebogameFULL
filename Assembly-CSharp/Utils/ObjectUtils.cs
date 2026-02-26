using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public static class ObjectUtils
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1F69", Offset = "0x1F69", VA = "0x1F69")]
		public static bool IsNull(this UnityEngine.Object obj)
		{
		/* --- GHIDRA: IsNull ---
		int Utils_ObjectUtils__IsNull(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59a14 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_LayoutElement___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AbstractRewardRender___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1097);
		    DAT_ram_00a59a14 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param1_00 = func_ii_6805(uVar3,param2,
		                           Method_UnityEngine_Object_Instantiate_AbstractRewardRender___);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1_00,0);
		  uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_1097,0);
		  UnityEngine_Texture2D___ctor(uVar3,uVar1,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1_00,0);
		  piVar2 = (int *)UnityEngine_GameObject__GetComponent_object_
		                            (uVar3,Method_UnityEngine_GameObject_AddComponent_LayoutElement___);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x1a0) * 4))
		            (piVar2,1,*(undefined4 *)(*piVar2 + 0x1a4));
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1_00,0);
		  if (DAT_ram_00a65020 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a65020 = '\x01';
		  }
		  local_20 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  local_18 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		  local_10 = local_20;
		  local_8 = local_18;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar3,&local_20,0);
		  *(undefined4 *)(param1_00 + 0x18) = param3;
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1A85", Offset = "0x1A85", VA = "0x1A85")]
		public static bool IsNotNull(this UnityEngine.Object obj)
		{
		/* --- GHIDRA: IsNotNull ---
		void Utils_ObjectUtils__IsNotNull(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (param2 == 0) {
		      uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                        (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  else if (cVar1 == '\0') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_00005192 + 0x36;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Player_ram_00005192 + 0x37;
		  return;
		}
		*/

			return default(bool);
		}
	}
}
