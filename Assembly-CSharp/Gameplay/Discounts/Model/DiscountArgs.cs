using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x02000899 RID: 2201
	[Token(Token = "0x2000899")]
	public class DiscountArgs : IDiscountArgs, IManageDiscountArgs
	{
		// Token: 0x060033D6 RID: 13270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x840E", Offset = "0x840E", VA = "0x840E")]
		public DiscountArgs(DiscountTargets discountTarget)
		{
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x17000A44")]
		public DiscountTargets DiscountTarget
		{
			[Token(Token = "0x60033D7")]
			[Address(RVA = "0x840F", Offset = "0x840F", VA = "0x840F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return DiscountTargets.UnknownDiscountTarget;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060033D9 RID: 13273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A45")]
		public ResourceSet Value
		{
			[Token(Token = "0x60033D8")]
			[Address(RVA = "0x8410", Offset = "0x8410", VA = "0x8410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033D9")]
			[Address(RVA = "0x8411", Offset = "0x8411", VA = "0x8411")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060033DB RID: 13275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A46")]
		public DiscountData Data
		{
			[Token(Token = "0x60033DA")]
			[Address(RVA = "0x8412", Offset = "0x8412", VA = "0x8412", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033DB")]
			[Address(RVA = "0x8413", Offset = "0x8413", VA = "0x8413", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Discounts_Model_DiscountArgs__set_Data(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57cb9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_DiscountData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_DiscountTargets__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_DiscountTargets__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57cb9 = '\x01';
		  }
		  iVar5 = Method_System_Array_Empty_DiscountData___;
		  iVar4 = *(int *)(Method_System_Array_Empty_DiscountData___ + 0x1c);
		  if (iVar4 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_DiscountData___);
		    iVar4 = *(int *)(iVar5 + 0x1c);
		  }
		  iVar4 = *(int *)(iVar4 + 8);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  if (*(int *)(iVar4 + 0x74) == 0) {
		    func_ii_306000(iVar4);
		  }
		  iVar5 = *(int *)(*(int *)(iVar5 + 0x1c) + 8);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  *(undefined4 *)(param1 + 0x10) = **(undefined4 **)(iVar5 + 0x5c);
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_DiscountTargets__double__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_DiscountTargets__double___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80e457c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e457c3:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  return;
		}
		*/

}
