using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Collections.Controller.Filters
{
	// Token: 0x020009EA RID: 2538
	[Token(Token = "0x20009EA")]
	public class CollectionAvailableFilter : ICollectionFilter
	{
		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06003CA4 RID: 15524 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003CA5 RID: 15525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF0")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6003CA4")]
			[Address(RVA = "0x8B6B", Offset = "0x8B6B", VA = "0x8B6B", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CA5")]
			[Address(RVA = "0x8B6C", Offset = "0x8B6C", VA = "0x8B6C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x8B6D", Offset = "0x8B6D", VA = "0x8B6D")]
		public CollectionAvailableFilter(UserData user, IRequirementValidator requirementValidator)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Collections_Controller_Filters_CollectionAvailableFilter___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57eea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    DAT_ram_00a57eea = '\x01';
		  }
		  uVar2 = 1;
		  if ((*(char *)(*(int *)(param1 + 0x10) + 0x10) != '\0') &&
		     (iVar3 = func_ii_7264(param2,0), iVar3 == 0)) {
		    param1_00 = *(int **)(param1 + 0xc);
		    iVar3 = Core_Data_CollectionData__get_NextMedalDic(param2,0);
		    uVar2 = *(undefined4 *)(iVar3 + 0x14);
		    uVar5 = *(undefined4 *)(param1 + 8);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		          goto code_r0x80e7d119;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,
		                                  Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo
		                                  ,6);
		code_r0x80e7d119:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar2,uVar5,puVar4[1]);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x8B6E", Offset = "0x8B6E", VA = "0x8B6E", Slot = "6")]
		public bool Filter(CollectionData collectionData)
		{
			return default(bool);
		}

		// Token: 0x04002181 RID: 8577
		[Token(Token = "0x4002181")]
		[FieldOffset(Offset = "0x8")]
		private readonly UserData _user;

		// Token: 0x04002182 RID: 8578
		[Token(Token = "0x4002182")]
		[FieldOffset(Offset = "0xC")]
		private readonly IRequirementValidator _requirementValidator;
	}
}
