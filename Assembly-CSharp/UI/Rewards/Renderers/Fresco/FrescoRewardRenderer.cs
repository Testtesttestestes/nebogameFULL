using System;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers.Fresco
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	public class FrescoRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x5EC7", Offset = "0x5EC7", VA = "0x5EC7", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		/* --- GHIDRA: HandleRewardChanged ---
		void UI_Rewards_Renderers_Fresco_FrescoRewardRenderer__HandleRewardChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = 0x3f8000003f800000;
		  local_30 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_24,&local_38,0);
		  *(undefined4 *)(param1 + 0x20) = (undefined4)local_24;
		  local_1c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_14,&local_48,0);
		  *(undefined4 *)(param1 + 0x24) = local_14;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x5EC8", Offset = "0x5EC8", VA = "0x5EC8")]
		public FrescoRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_Fresco_FrescoRewardRenderer___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59a3b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a59a3b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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
	}
}
