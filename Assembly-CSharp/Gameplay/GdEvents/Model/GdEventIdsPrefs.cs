using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	public class GdEventIdsPrefs
	{
		// Token: 0x06002C95 RID: 11413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C95")]
		[Address(RVA = "0x7D22", Offset = "0x7D22", VA = "0x7D22")]
		public GdEventIdsPrefs(string name)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_GdEvents_Model_GdEventIdsPrefs___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int param1_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a2cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Contains__);
		    DAT_ram_00a5a2cd = '\x01';
		  }
		  uVar2 = System_Collections_Generic_List_uint___GetEnumerator
		                    (*(undefined4 *)(*(int *)(param1 + 0xc) + 8),param2,
		                     Method_System_Collections_Generic_List_uint__Contains__);
		  iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		  if (uVar2 == 0) {
		    param1_00 = *(int *)(*(int *)(param1 + 0xc) + 8);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  return uVar2 ^ 1;
		}
		*/

		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x6002C96")]
		[Address(RVA = "0x7D23", Offset = "0x7D23", VA = "0x7D23")]
		public bool TryAdd(uint v)
		{
		/* --- GHIDRA: TryAdd ---
		undefined4
		Gameplay_GdEvents_Model_GdEventIdsPrefs__TryAdd(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Remove__);
		    DAT_ram_00a5a2ce = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_uint___IsCompatibleObject
		                    (*(undefined4 *)(*(int *)(param1 + 0xc) + 8),param2,
		                     Method_System_Collections_Generic_List_uint__Remove__);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x6002C97")]
		[Address(RVA = "0x7D24", Offset = "0x7D24", VA = "0x7D24")]
		public bool TryRemove(uint v)
		{
		/* --- GHIDRA: TryRemove ---
		void Gameplay_GdEvents_Model_GdEventIdsPrefs__TryRemove(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a2cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Clear__);
		    DAT_ram_00a5a2cf = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0xc) + 8);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C98")]
		[Address(RVA = "0x7D25", Offset = "0x7D25", VA = "0x7D25")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		undefined4
		Gameplay_GdEvents_Model_GdEventIdsPrefs__Clear(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Contains__);
		    DAT_ram_00a5a2d0 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_uint___GetEnumerator
		                    (*(undefined4 *)(*(int *)(param1 + 0xc) + 8),param2,
		                     Method_System_Collections_Generic_List_uint__Contains__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x6002C99")]
		[Address(RVA = "0x7D26", Offset = "0x7D26", VA = "0x7D26")]
		public bool Contains(uint v)
		{
		/* --- GHIDRA: Contains ---
		void Gameplay_GdEvents_Model_GdEventIdsPrefs__Contains(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 8);
		  param2_00 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor
		                        (*(undefined4 *)(param1 + 0xc),0);
		  func_ii_7893(param1_00,param2_00,0);
		  func_ii_10838(0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x7D27", Offset = "0x7D27", VA = "0x7D27")]
		public void Commit()
		{
		/* --- GHIDRA: Commit ---
		void Gameplay_GdEvents_Model_GdEventIdsPrefs__Commit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a2d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    DAT_ram_00a5a2d1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_uint___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04001882 RID: 6274
		[Token(Token = "0x4001882")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Name;

		// Token: 0x04001883 RID: 6275
		[Token(Token = "0x4001883")]
		[FieldOffset(Offset = "0xC")]
		private GdEventIdsPrefs.ValuesWrapper _data;

		// Token: 0x0200074F RID: 1871
		[Token(Token = "0x200074F")]
		private class ValuesWrapper
		{
			// Token: 0x06002C9B RID: 11419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C9B")]
			[Address(RVA = "0x7D28", Offset = "0x7D28", VA = "0x7D28")]
			public ValuesWrapper()
			{
			}

			// Token: 0x04001884 RID: 6276
			[Token(Token = "0x4001884")]
			[FieldOffset(Offset = "0x8")]
			public readonly List<uint> Values;
		}
	}
}
