using System;
using System.Collections.Generic;
using Core.Data.InfoRows;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Requirements.ListFillBehaviors
{
	// Token: 0x0200119A RID: 4506
	[Token(Token = "0x200119A")]
	public class DefaultListFillBehavior : IListFillBehavior
	{
		// Token: 0x06006B15 RID: 27413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B15")]
		[Address(RVA = "0xB61C", Offset = "0xB61C", VA = "0xB61C", Slot = "4")]
		public void Add(IList<IInformationRow> collection, IInformationProvider provider)
		{
		/* --- GHIDRA: Add ---
		void Core_Gameplay_Managers_Requirements_ListFillBehaviors_DefaultListFillBehavior__Add
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a643 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		    DAT_ram_00a5a643 = '\x01';
		  }
		  Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle
		            (param2,param3,Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		  return;
		}
		*/

		/* --- GHIDRA: Add ---
		void Core_Gameplay_Managers_Requirements_ListFillBehaviors_DefaultListFillBehavior__Add
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a643 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		    DAT_ram_00a5a643 = '\x01';
		  }
		  Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle
		            (param2,param3,Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		  return;
		}
		*/

		/* --- GHIDRA: Add ---
		void Core_Gameplay_Managers_Requirements_ListFillBehaviors_DefaultListFillBehavior__Add
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a643 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		    DAT_ram_00a5a643 = '\x01';
		  }
		  Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle
		            (param2,param3,Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		  return;
		}
		*/

		/* --- GHIDRA: Add ---
		void Core_Gameplay_Managers_Requirements_ListFillBehaviors_DefaultListFillBehavior__Add
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a643 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		    DAT_ram_00a5a643 = '\x01';
		  }
		  Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle
		            (param2,param3,Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		  return;
		}
		*/

		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B16")]
		[Address(RVA = "0xB61D", Offset = "0xB61D", VA = "0xB61D", Slot = "5")]
		public void Add(IList<IInformationRow> collection, IInformationRow title, IList<IInformationRow> rows)
		{
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B17")]
		[Address(RVA = "0xB61E", Offset = "0xB61E", VA = "0xB61E", Slot = "6")]
		public void Add(IList<IInformationRow> collection, IEnumerable<IInformationRow> rows)
		{
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B18")]
		[Address(RVA = "0xB61F", Offset = "0xB61F", VA = "0xB61F", Slot = "7")]
		public void Add(IList<IInformationRow> collection, params IInformationRow[] rows)
		{
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B19")]
		[Address(RVA = "0xB620", Offset = "0xB620", VA = "0xB620")]
		public DefaultListFillBehavior()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_ListFillBehaviors_DefaultListFillBehavior___ctor
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a644 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationProvider_TypeInfo);
		    DAT_ram_00a5a644 = '\x01';
		  }
		  iVar3 = *param3;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x8124942c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Data_InfoRows_IInformationProvider_TypeInfo,1);
		code_r0x8124942c:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  if (DAT_ram_00a5a646 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		    DAT_ram_00a5a646 = '\x01';
		  }
		  Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle
		            (param2,param2_00,Method_Sirenix_Utilities_LinqExtensions_AddRange_IInformationRow___);
		  return;
		}
		*/

		}
	}
}
