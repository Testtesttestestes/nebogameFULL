using System;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000947 RID: 2375
	[Token(Token = "0x2000947")]
	[Serializable]
	public class RankImages
	{
		// Token: 0x06003832 RID: 14386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003832")]
		[Address(RVA = "0x87E9", Offset = "0x87E9", VA = "0x87E9")]
		public RankImages()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_View_RankView_RankImages___ctor
		               (int param1,undefined4 param2,int *param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5825e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UIElementsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UIElementsDic__get_Item__);
		    DAT_ram_00a5825e = '\x01';
		  }
		  do {
		    iVar4 = *param4;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar5) {
		          puVar2 = (uint *)(piVar5[1] * 8 + iVar4 + 0xd0);
		          goto code_r0x80ec0ef5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ec0ef5:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param4,puVar2[1]);
		    if (*(int *)(*(int *)(iVar4 + 0x1c8) + 0xc) <= iVar3) {
		      return;
		    }
		    iVar4 = *param4;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar5) {
		          puVar2 = (uint *)(piVar5[1] * 8 + iVar4 + 0xd0);
		          goto code_r0x80ec0f7b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ec0f7b:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param4,puVar2[1]);
		    iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar4 + 0x1c8),iVar3,
		                       Method_Google_Protobuf_Collections_RepeatedField_UIElementsDic__get_Item__);
		    iVar3 = iVar3 + 1;
		  } while (*(int *)(iVar4 + 0xc) != *(int *)(param1 + 0x10));
		  uVar1 = 0;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  uVar6 = *(undefined4 *)(iVar4 + 0x14);
		  iVar3 = *param3;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80ec1033;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,
		                                Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo,2
		                               );
		code_r0x80ec1033:
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param3,uVar6,param2,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x04001F11 RID: 7953
		[Token(Token = "0x4001F11")]
		[FieldOffset(Offset = "0x8")]
		public RankTypes Rank;

		// Token: 0x04001F12 RID: 7954
		[Token(Token = "0x4001F12")]
		[FieldOffset(Offset = "0xC")]
		public Image Image;
	}
}
