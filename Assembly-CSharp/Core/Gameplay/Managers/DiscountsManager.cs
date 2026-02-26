using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Discounts.Controller;
using Gameplay.Discounts.Events;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001164 RID: 4452
	[Token(Token = "0x2001164")]
	public class DiscountsManager : IGameManager, IBaseManager, IDiscountHandler
	{
		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x060068F6 RID: 26870 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700157B")]
		public string Name
		{
			[Token(Token = "0x60068F6")]
			[Address(RVA = "0xB41A", Offset = "0xB41A", VA = "0xB41A", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000280 RID: 640
		// (add) Token: 0x060068F7 RID: 26871 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068F8 RID: 26872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000280")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068F7")]
			[Address(RVA = "0xB41B", Offset = "0xB41B", VA = "0xB41B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068F8")]
			[Address(RVA = "0xB41C", Offset = "0xB41C", VA = "0xB41C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000281 RID: 641
		// (add) Token: 0x060068F9 RID: 26873 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068FA RID: 26874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000281")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068F9")]
			[Address(RVA = "0xB41D", Offset = "0xB41D", VA = "0xB41D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068FA")]
			[Address(RVA = "0xB41E", Offset = "0xB41E", VA = "0xB41E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x060068FB RID: 26875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700157C")]
		public IDiscountsProvider DiscountsProvider
		{
			[Token(Token = "0x60068FB")]
			[Address(RVA = "0xB41F", Offset = "0xB41F", VA = "0xB41F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x060068FC RID: 26876 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068FD RID: 26877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157D")]
		public DiscountsModel Model
		{
			[Token(Token = "0x60068FC")]
			[Address(RVA = "0xB420", Offset = "0xB420", VA = "0xB420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068FD")]
			[Address(RVA = "0xB421", Offset = "0xB421", VA = "0xB421")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x060068FE RID: 26878 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068FF RID: 26879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157E")]
		public DiscountsController Controller
		{
			[Token(Token = "0x60068FE")]
			[Address(RVA = "0xB422", Offset = "0xB422", VA = "0xB422")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068FF")]
			[Address(RVA = "0xB423", Offset = "0xB423", VA = "0xB423")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06006900 RID: 26880 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006901 RID: 26881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157F")]
		public DiscountsEvents Events
		{
			[Token(Token = "0x6006900")]
			[Address(RVA = "0xB424", Offset = "0xB424", VA = "0xB424")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006901")]
			[Address(RVA = "0xB425", Offset = "0xB425", VA = "0xB425")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006902")]
		[Address(RVA = "0xB426", Offset = "0xB426", VA = "0xB426")]
		public DiscountsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_DiscountsManager___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param3;
		  
		  if (DAT_ram_00a637c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Controller_DiscountsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Events_DiscountsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_DiscountsManager_ResolveDiscountsProvider__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_DiscountsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a637c0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Discounts_Events_DiscountsEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar4 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar4 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x823001f5;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x823001f5:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (*(int *)(iVar5 + 0x14) != 0) {
		    uVar1 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		  }
		  uVar3 = unnamed_function_1417(Gameplay_Discounts_Model_DiscountsModel_TypeInfo);
		  Gameplay_Discounts_Model_DiscountArgs__set_Data(uVar3,uVar1,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  param3 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Gameplay_Discounts_Controller_DiscountsController_TypeInfo);
		  Gameplay_Discounts_Events_DiscountsEvents___ctor(uVar1,uVar3,param3,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  MVC_AbstractController__Dispose(uVar1,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x10) + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Gameplay_Managers_DiscountsManager_ResolveDiscountsProvider__,
		             0);
		  Core_Data_UserData__remove_UserSkillsChangedEvent(uVar3,uVar1,0);
		  if (DAT_ram_00a637c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_EmptyDiscountsProvider_TypeInfo);
		    DAT_ram_00a637c1 = '\x01';
		  }
		  uVar4 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(*(int *)(param1 + 0x10) + 8),0);
		  iVar5 = *(int *)(param1 + 0x20);
		  if (uVar4 < 4) {
		    uVar1 = unnamed_function_1417(Gameplay_Discounts_Model_EmptyDiscountsProvider_TypeInfo);
		  }
		  else {
		    uVar1 = *(undefined4 *)(param1 + 0x10);
		  }
		  *(undefined4 *)(iVar5 + 8) = uVar1;
		  iVar5 = *(int *)(param1 + 8);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006903 RID: 26883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006903")]
		[Address(RVA = "0xB427", Offset = "0xB427", VA = "0xB427", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_DiscountsManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a637c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_EmptyDiscountsProvider_TypeInfo);
		    DAT_ram_00a637c1 = '\x01';
		  }
		  uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(*(int *)(param1 + 0x10) + 8),0);
		  iVar3 = *(int *)(param1 + 0x20);
		  if (3 < uVar1) {
		    *(undefined4 *)(iVar3 + 8) = *(undefined4 *)(param1 + 0x10);
		    return;
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Discounts_Model_EmptyDiscountsProvider_TypeInfo);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x06006904 RID: 26884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006904")]
		[Address(RVA = "0xB428", Offset = "0xB428", VA = "0xB428")]
		private void ResolveDiscountsProvider()
		{
		/* --- GHIDRA: ResolveDiscountsProvider ---
		void Core_Gameplay_Managers_DiscountsManager__ResolveDiscountsProvider(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a637c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_DiscountsManager_ResolveDiscountsProvider__);
		    DAT_ram_00a637c2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_DiscountsManager_ResolveDiscountsProvider__,0);
		  Core_Data_UserData__add_OnUserLevelChangedEvent(param1_01,param1_00,0);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor
		            (*(undefined4 *)(param1 + 0x20),0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006905 RID: 26885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006905")]
		[Address(RVA = "0xB429", Offset = "0xB429", VA = "0xB429", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_DiscountsManager__Deinit(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  undefined8 uVar2;
		  int param1_00;
		  uint *puVar3;
		  uint uVar4;
		  int param1_01;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  double param1_02;
		  int iVar10;
		  undefined4 local_c;
		  float8 local_8;
		  
		  iVar10 = 0;
		  if (DAT_ram_00a637c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_DiscountArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDiscountArgs__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDiscountArgs___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IDiscountArgs__TypeInfo);
		    DAT_ram_00a637c3 = '\x01';
		  }
		  local_8 = 0.0;
		  local_c = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IDiscountArgs__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IDiscountArgs___ctor__);
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IDiscountTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8230052d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Discounts_Model_IDiscountTarget_TypeInfo,0);
		code_r0x8230052d:
		  param1_02 = (double)CONCAT44(in_register_20000004,param2);
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(param1_02,puVar3[1]);
		  uVar5 = (undefined4)((ulonglong)param1_02 >> 0x20);
		  if (0 < *(int *)(iVar8 + 0xc)) {
		    do {
		      uVar5 = (undefined4)((ulonglong)param1_02 >> 0x20);
		      param2_00 = *(undefined4 *)(iVar8 + iVar10 * 4 + 0x10);
		      piVar6 = *(int **)(param1 + 0x20);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo == *piVar9) {
		            puVar3 = (uint *)(piVar9[1] * 8 + iVar7 + 200);
		            goto code_r0x823005c1;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,1);
		code_r0x823005c1:
		      uVar2 = CONCAT44(uVar5,piVar6);
		      uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(uVar2,param2_00,&local_8,puVar3[1]);
		      uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      piVar6 = *(int **)(param1 + 0x20);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar4 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8);
		          if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo == *piVar9) {
		            puVar3 = (uint *)(iVar7 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x82300649;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar4);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,0);
		code_r0x82300649:
		      param1_02 = (double)CONCAT44(uVar5,piVar6);
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_02,param2_00,&local_c,puVar3[1]);
		      if ((uVar4 | uVar1) == 1) {
		        param1_01 = unnamed_function_1417(Gameplay_Discounts_Model_DiscountArgs_TypeInfo);
		        Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_01,param2_00,0);
		        param1_02 = 1.0 - (double)local_8;
		        uVar5 = Utils_MoneyUtils__CreateZero(param1_02,0);
		        *(undefined4 *)(param1_01 + 0xc) = uVar5;
		        *(undefined4 *)(param1_01 + 0x10) = local_c;
		        iVar7 = Method_System_Collections_Generic_List_IDiscountArgs__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar1 = *(uint *)(param1_00 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = param1_01;
		        }
		        else {
		          param1_02 = (double)CONCAT44((int)((ulonglong)param1_02 >> 0x20),param1_00);
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param1_01,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      uVar5 = (undefined4)((ulonglong)param1_02 >> 0x20);
		      iVar10 = iVar10 + 1;
		    } while (iVar10 < *(int *)(iVar8 + 0xc));
		  }
		  uVar1 = 0;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		        goto code_r0x8230077d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Discounts_Model_IDiscountTarget_TypeInfo,1);
		code_r0x8230077d:
		  (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(uVar5,param2),param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006906 RID: 26886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006906")]
		[Address(RVA = "0xB42A", Offset = "0xB42A", VA = "0xB42A", Slot = "11")]
		public void Handle(IDiscountTarget target)
		{
		/* --- GHIDRA: Handle ---
		uint Core_Gameplay_Managers_DiscountsManager__Handle(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  uVar1 = Core_Data_UserData__set_LevelDic(param1,0);
		  return (uint)(3 < uVar1);
		}
		*/

		}

		// Token: 0x06006907 RID: 26887 RVA: 0x00013950 File Offset: 0x00011B50
		[Token(Token = "0x6006907")]
		[Address(RVA = "0xB42B", Offset = "0xB42B", VA = "0xB42B")]
		public static bool AllowShowDiscounts(UserData userData)
		{
		/* --- GHIDRA: AllowShowDiscounts ---
		undefined4
		Core_Gameplay_Managers_DiscountsManager__AllowShowDiscounts(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_6668);
		    DAT_ram_00a637c4 = '\x01';
		  }
		  return StringLiteral_6668;
		}
		*/

			return default(bool);
		}

		// Token: 0x040037BB RID: 14267
		[Token(Token = "0x40037BB")]
		private const int MIN_LEVEL_TO_SHOW_DISCOUNTS = 4;

		// Token: 0x040037C1 RID: 14273
		[Token(Token = "0x40037C1")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IGame _game;

		// Token: 0x040037C2 RID: 14274
		[Token(Token = "0x40037C2")]
		[FieldOffset(Offset = "0x20")]
		private readonly DiscountsProviderDecorator _discountsProviderDecorator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_DiscountsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637bb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_DiscountsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637bc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_DiscountsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637bd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_DiscountsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637be = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: set_Events ---
		void Core_Gameplay_Managers_DiscountsManager__set_Events
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a637bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_DiscountsProviderDecorator_TypeInfo);
		    DAT_ram_00a637bf = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Discounts_Model_DiscountsProviderDecorator_TypeInfo);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

}
