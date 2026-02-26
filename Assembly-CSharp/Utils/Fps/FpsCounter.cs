using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Utils.Fps
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public class FpsCounter : AbstractFpsCounter
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x579C", Offset = "0x579C", VA = "0x579C", Slot = "4")]
		public override void HandleUpdate()
		{
		/* --- GHIDRA: HandleUpdate ---
		void Utils_Fps_FpsCounter__HandleUpdate(int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a62846 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a62846 = '\x01';
		  }
		  if (ABS(param2) < 2.1474836e+09) {
		    local_4 = (int)param2;
		  }
		  else {
		    local_4 = -0x80000000;
		  }
		  iVar1 = func_ii_4443(&local_4,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  iVar2 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x1c),iVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x579D", Offset = "0x579D", VA = "0x579D", Slot = "5")]
		public override void HandleFpsCalculated(float fps)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x579E", Offset = "0x579E", VA = "0x579E")]
		public FpsCounter()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_Fps_FpsCounter___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62847 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_float__TypeInfo);
		    DAT_ram_00a62847 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_float__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_float__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _image;
	}
}
