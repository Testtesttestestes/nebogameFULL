using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200112F RID: 4399
	[Token(Token = "0x200112F")]
	public class DictNameSource : IDictNameSource
	{
		// Token: 0x1400024B RID: 587
		// (add) Token: 0x06006718 RID: 26392 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006719 RID: 26393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024B")]
		public event Action<IDictNameSource> ChangedEvent
		{
			[Token(Token = "0x6006718")]
			[Address(RVA = "0xB250", Offset = "0xB250", VA = "0xB250", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006719")]
			[Address(RVA = "0xB251", Offset = "0xB251", VA = "0xB251", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671A")]
		[Address(RVA = "0xB252", Offset = "0xB252", VA = "0xB252")]
		public DictNameSource(string name)
		{
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600671B")]
		[Address(RVA = "0xB253", Offset = "0xB253", VA = "0xB253", Slot = "6")]
		public string GetValue()
		{
		/* --- GHIDRA: GetValue ---
		void Core_Gameplay_Managers_DictNameSource__GetValue(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0xc),param2,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0xc) = param2;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671C")]
		[Address(RVA = "0xB254", Offset = "0xB254", VA = "0xB254")]
		public void SetValue(string value)
		{
		/* --- GHIDRA: SetValue ---
		undefined4 Core_Gameplay_Managers_DictNameSource__SetValue(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a935 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_10646);
		    DAT_ram_00a5a935 = '\x01';
		  }
		  return StringLiteral_10646;
		}
		*/

		}

		// Token: 0x04003706 RID: 14086
		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0xC")]
		private string _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void Core_Gameplay_Managers_DictNameSource__add_ChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a934 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDictNameSource__TypeInfo);
		    DAT_ram_00a5a934 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IDictNameSource__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IDictNameSource__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
