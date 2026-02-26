using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x200079D")]
	public class CollectionsTag_33 : AbstractTag
	{
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x170008F2")]
		public uint CollectionId
		{
			[Token(Token = "0x6002E5A")]
			[Address(RVA = "0x7ED5", Offset = "0x7ED5", VA = "0x7ED5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x170008F3")]
		public uint Rank
		{
			[Token(Token = "0x6002E5B")]
			[Address(RVA = "0x7ED6", Offset = "0x7ED6", VA = "0x7ED6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x7ED7", Offset = "0x7ED7", VA = "0x7ED7", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x7ED8", Offset = "0x7ED8", VA = "0x7ED8")]
		public CollectionsTag_33()
		{
		}

		// Token: 0x0400196F RID: 6511
		[Token(Token = "0x400196F")]
		public const string COLLECTION_TITLE = "collection_title";

		// Token: 0x04001970 RID: 6512
		[Token(Token = "0x4001970")]
		public const string COLLECTION_RANK = "collection_rank";

		// Token: 0x04001971 RID: 6513
		[Token(Token = "0x4001971")]
		public const string COLLECTION_VIEW = "collection_view";

		// Token: 0x04001972 RID: 6514
		[Token(Token = "0x4001972")]
		public const string VIEW_PREFAB = "CollectionTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Rank ---
		int Gameplay_GameEvents_Model_Tags_CollectionsTag_33__get_Rank
		              (int *param1,undefined4 param2,int param3,int *param4,int param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  int *param1_00;
		  double dVar7;
		  uint uVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 local_10;
		  undefined4 *local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a574d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_CollectionTagView___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5548);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21409);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21408);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21410);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574d2 = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		    return 0;
		  }
		  iVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		  *param4 = iVar3;
		  iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21409,0);
		  if (iVar3 != 0) {
		    param1_00 = (int *)param1[2];
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80d9434b;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d9434b:
		    uVar1 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		    dVar7 = *(double *)(param1[5] + 0x10);
		    if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		      iVar3 = (int)dVar7;
		    }
		    else {
		      iVar3 = 0;
		    }
		    if (ABS(dVar7) < 2147483648.0) {
		      iVar9 = (int)dVar7;
		    }
		    else {
		      iVar9 = -0x80000000;
		    }
		    if (0.0 <= dVar7) {
		      iVar9 = iVar3;
		    }
		    uVar1 = func_ii_6816(uVar1,iVar9,0);
		    iVar3 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAvatarRibbonAssetId(uVar1,0);
		    *param4 = iVar3;
		    return iVar2;
		  }
		  iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21408,0);
		  if (iVar3 != 0) {
		    dVar7 = *(double *)(param1[5] + 0x18);
		    if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		      iVar3 = (int)dVar7;
		    }
		    else {
		      iVar3 = 0;
		    }
		    if (ABS(dVar7) < 2147483648.0) {
		      local_4 = (int)dVar7;
		    }
		    else {
		      local_4 = -0x80000000;
		    }
		    if (0.0 <= dVar7) {
		      local_4 = iVar3;
		    }
		    iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    if (iVar3 == 0) {
		      iVar3 = StringLiteral_5;
		    }
		    *param4 = iVar3;
		    return iVar2;
		  }
		  iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21410,0);
		  if (iVar3 == 0) {
		    return iVar2;
		  }
		  *param4 = StringLiteral_5;
		  if (param5 == 0) {
		    return iVar2;
		  }
		  iVar3 = param1[2];
		  uVar1 = unnamed_function_1417(Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo)
		  ;
		  Gameplay_Collections_Model_Factories_CollectionDataFactory__Dispose(uVar1,iVar3,0);
		  local_10 = 0;
		  local_c = &local_8;
		  DAT_ram_009d3e38 = 0;
		  local_8 = uVar1;
		  uVar4 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d8,2,
		                     Core_Dict_IDictProvider_TypeInfo,param1[2]);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    dVar7 = *(double *)(param1[5] + 0x10);
		    DAT_ram_009d3e38 = 0;
		    if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		      iVar3 = (int)dVar7;
		    }
		    else {
		      iVar3 = 0;
		    }
		    if (ABS(dVar7) < 2147483648.0) {
		      iVar9 = (int)dVar7;
		    }
		    else {
		      iVar9 = -0x80000000;
		    }
		    if (0.0 <= dVar7) {
		      iVar9 = iVar3;
		    }
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d9,uVar4,iVar9,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2da,uVar1,uVar4,0);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2db,param1,
		                           StringLiteral_5548,*(undefined4 *)(param5 + 8),
		                           Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_CollectionTagView___
		                          );
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2dc,
		                     *(undefined4 *)(iVar9 + 0x10),param1[2],
		                     *(undefined4 *)(*(int *)(param3 + 0x18) + 8),0);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            *(undefined4 *)(*(int *)(iVar9 + 0x10) + 0x28) = uVar1;
		            dVar7 = *(double *)(param1[5] + 0x18);
		            DAT_ram_009d3e38 = 0;
		            if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		              iVar3 = (int)dVar7;
		            }
		            else {
		              iVar3 = 0;
		            }
		            if (ABS(dVar7) < 2147483648.0) {
		              iVar10 = (int)dVar7;
		            }
		            else {
		              iVar10 = -0x80000000;
		            }
		            if (0.0 <= dVar7) {
		              iVar10 = iVar3;
		            }
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2dd,uVar1,iVar10,0);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 == 1) {
		              uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              dVar7 = *(double *)(param1[5] + 0x18);
		              DAT_ram_009d3e38 = 0;
		              if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		                iVar3 = (int)dVar7;
		              }
		              else {
		                iVar3 = 0;
		              }
		              if (ABS(dVar7) < 2147483648.0) {
		                iVar10 = (int)dVar7;
		              }
		              else {
		                iVar10 = -0x80000000;
		              }
		              if (0.0 <= dVar7) {
		                iVar10 = iVar3;
		              }
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2de,
		                         *(undefined4 *)(iVar9 + 0x10),iVar10,0);
		              iVar3 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar3 != 1) goto code_r0x80d9473a;
		              uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		          }
		        }
		      }
		    }
		  }
		  iVar3 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar9) {
		    puVar6 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    local_10 = *puVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80d9473a:
		      DAT_ram_009d3e38 = 0;
		      Unity_Services_Core_Scheduler_Internal_MinimumBinaryHeap_object___Insert(&local_10);
		      return iVar2;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2df,&local_10);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
