using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI.Elements.Buildings
{
	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	public class SpellListArgs : SelectedGenericListArgs<SpellItemArgs>
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x60E3", Offset = "0x60E3", VA = "0x60E3")]
		public SpellListArgs()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_Buildings_SpellListArgs___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x2c),0,0);
		  }
		  iVar2 = 0x14;
		  if (param2 == 0) {
		    iVar2 = 0x20;
		  }
		  local_8 = *(undefined4 *)((undefined8 *)(param1 + iVar2) + 1);
		  local_10 = *(undefined8 *)(param1 + iVar2);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_18 = local_8;
		  local_20 = local_10;
		  uVar1 = DG_Tweening_ShortcutExtensions__DORotateQuaternion
		                    (uVar1,&local_20,*(float *)(param1 + 0x10),0,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void UI_Elements_Buildings_SpellListArgs___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x2c),0,0);
		  }
		  iVar2 = 0x14;
		  if (param2 == 0) {
		    iVar2 = 0x20;
		  }
		  local_8 = *(undefined4 *)((undefined8 *)(param1 + iVar2) + 1);
		  local_10 = *(undefined8 *)(param1 + iVar2);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_18 = local_8;
		  local_20 = local_10;
		  uVar1 = DG_Tweening_ShortcutExtensions__DORotateQuaternion
		                    (uVar1,&local_20,*(float *)(param1 + 0x10),0,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x60E4", Offset = "0x60E4", VA = "0x60E4")]
		public SpellListArgs(List<SpellItemArgs> list)
		{
		}
	}
}
