using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Base.Events
{
	// Token: 0x02000CFE RID: 3326
	[Token(Token = "0x2000CFE")]
	public class BaseIsleEvents : AbstractMVCEvents
	{
		// Token: 0x06005130 RID: 20784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005130")]
		[Address(RVA = "0x9F20", Offset = "0x9F20", VA = "0x9F20")]
		public BaseIsleEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Base_Events_BaseIsleEvents___ctor
		               (int param1,undefined8 param2,undefined4 param3,int *param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined8 uVar2;
		  int param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  int iVar5;
		  
		  if (DAT_ram_00a58ced == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__set_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__set_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_Controller_AxisIsleController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_Events_AxisIsleEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_Model_AxisIsleModel_TypeInfo);
		    DAT_ram_00a58ced = '\x01';
		  }
		  uVar2 = param2;
		  Facebook_Unity_Subscription__get_PeriodStartTime
		            (param1,param2,
		             Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum___ctor__
		            );
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  param1_00 = unnamed_function_1417(Gameplay_Isles_Axis_Model_AxisIsleModel_TypeInfo);
		  if (DAT_ram_00a58d03 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d03 = '\x01';
		  }
		  uVar1 = 0;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param3,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param5;
		  *(undefined8 *)(param1_00 + 0x10) = param2;
		  *(int **)(param1_00 + 0x28) = param4;
		  iVar5 = *param4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 600);
		        goto code_r0x80f9ba6c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param4,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9ba6c:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param4,CONCAT44(uVar4,puVar3[1]));
		  *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(iVar5 + 0x14);
		  *(int *)(param1 + 0x10) = param1_00;
		  uVar4 = unnamed_function_1417(Gameplay_Isles_Axis_Events_AxisIsleEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  param2_00 = *(undefined4 *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(Gameplay_Isles_Axis_Controller_AxisIsleController_TypeInfo);
		  if (DAT_ram_00a58d04 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleController_AxisIsleModel__AxisIsleEvents___ctor__
		              );
		    DAT_ram_00a58d04 = '\x01';
		  }
		  UI_Windows_Buildings_BaseIsleBuildingWindowArgs___Il2CppFullySharedGenericType____ctor
		            (param1_01,param2_00,uVar4,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleController_AxisIsleModel__AxisIsleEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = param1_01;
		  MVC_AbstractController__Dispose(param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		[FieldOffset(Offset = "0x14")]
		public Action<uint> BuildingStateChangedEvent;

		// Token: 0x04002C37 RID: 11319
		[Token(Token = "0x4002C37")]
		[FieldOffset(Offset = "0x18")]
		public Action IsCurrentChangedEvent;

		// Token: 0x04002C38 RID: 11320
		[Token(Token = "0x4002C38")]
		[FieldOffset(Offset = "0x1C")]
		public Action IsleInformationChangedEvent;

		// Token: 0x04002C39 RID: 11321
		[Token(Token = "0x4002C39")]
		[FieldOffset(Offset = "0x20")]
		public Action DisposeEvent;
	}
}
