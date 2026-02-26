using System;
using System.Runtime.CompilerServices;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting
{
	// Token: 0x020011C8 RID: 4552
	[Token(Token = "0x20011C8")]
	public class RoutingManager : IGameManager, IBaseManager, IRouter
	{
		// Token: 0x140002CB RID: 715
		// (add) Token: 0x06006C6E RID: 27758 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C6F RID: 27759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CB")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C6E")]
			[Address(RVA = "0xB75A", Offset = "0xB75A", VA = "0xB75A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C6F")]
			[Address(RVA = "0xB75B", Offset = "0xB75B", VA = "0xB75B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002CC RID: 716
		// (add) Token: 0x06006C70 RID: 27760 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C71 RID: 27761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CC")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C70")]
			[Address(RVA = "0xB75C", Offset = "0xB75C", VA = "0xB75C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C71")]
			[Address(RVA = "0xB75D", Offset = "0xB75D", VA = "0xB75D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06006C72 RID: 27762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001627")]
		public string Name
		{
			[Token(Token = "0x6006C72")]
			[Address(RVA = "0xB75E", Offset = "0xB75E", VA = "0xB75E", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001628")]
		public ILocatorRepository LocatorRepository
		{
			[Token(Token = "0x6006C73")]
			[Address(RVA = "0xB75F", Offset = "0xB75F", VA = "0xB75F", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C74")]
			[Address(RVA = "0xB760", Offset = "0xB760", VA = "0xB760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001629")]
		public IGame Game
		{
			[Token(Token = "0x6006C75")]
			[Address(RVA = "0xB761", Offset = "0xB761", VA = "0xB761")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C76")]
			[Address(RVA = "0xB762", Offset = "0xB762", VA = "0xB762")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C77")]
		[Address(RVA = "0xB763", Offset = "0xB763", VA = "0xB763")]
		public RoutingManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_RoutingManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a6fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Uri__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_RoutingManager_HandleDeepLinkUriChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a5a6fd = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x180);
		        goto code_r0x8125e162;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x18);
		code_r0x8125e162:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (*(int *)(*(int *)(iVar5 + 0xc) + 0xc) == 1) {
		    uVar1 = 0;
		    piVar4 = *(int **)(param1 + 0x14);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x8125e1f2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125e1f2:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x8125e274;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x10);
		code_r0x8125e274:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = *(undefined4 *)(iVar5 + 0x18);
		    if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Uri_TypeInfo);
		    }
		    iVar5 = System_Xml_Schema_XmlSchemaSet__RemoveSchemaFromCaches(uVar3,0,0);
		    if (iVar5 != 0) {
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 0x14);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		            goto code_r0x8125e31c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125e31c:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      uVar1 = 0;
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		            goto code_r0x8125e3a0;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x10);
		code_r0x8125e3a0:
		      iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      Core_Gameplay_Managers_GameActivityRouting_RoutingManager__Deinit
		                (param1,*(undefined4 *)(iVar5 + 0x18),puVar2);
		    }
		  }
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x8125e429;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125e429:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x8125e4ab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x10);
		code_r0x8125e4ab:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1_00 = unnamed_function_1417(System_Action_Uri__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_RoutingManager_HandleDeepLinkUriChangedEvent__
		             ,0);
		  Core_Application_Managers_DeepLinkManager__remove_DeinitCompleteEvent(uVar3,param1_00,0);
		  iVar5 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		            (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C78")]
		[Address(RVA = "0xB764", Offset = "0xB764", VA = "0xB764", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_GameActivityRouting_RoutingManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a6fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Uri__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_RoutingManager_HandleDeepLinkUriChangedEvent__
		              );
		    DAT_ram_00a5a6fe = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8125e846;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125e846:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x8125e8c6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x10);
		code_r0x8125e8c6:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_01 = unnamed_function_1417(System_Action_Uri__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_RoutingManager_HandleDeepLinkUriChangedEvent__
		             ,0);
		  Core_Application_Managers_DeepLinkManager__add_UriChangedEvent(param1_00,param1_01,0);
		  piVar3 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8125e972;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x8125e972:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar4 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		            (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C79")]
		[Address(RVA = "0xB765", Offset = "0xB765", VA = "0xB765", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_GameActivityRouting_RoutingManager__Deinit
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *local_4;
		  
		  if (DAT_ram_00a5a6ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocatorRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocator_TypeInfo);
		    DAT_ram_00a5a6ff = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar5 = *(int **)(param1 + 0x10);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Rounting_ILocatorRepository_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8125e5b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Rounting_ILocatorRepository_TypeInfo,0);
		code_r0x8125e5b8:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,param2,&local_4,puVar2[1]);
		  if (iVar6 != 0) {
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 0x14);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x218);
		          goto code_r0x8125e647;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x8125e647:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar1 = 0;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8125e6c9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x8125e6c9:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (iVar6 == 0) {
		      uVar1 = 0;
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Rounting_ILocator_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x8125e74a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(local_4,Core_Rounting_ILocator_TypeInfo,2);
		code_r0x8125e74a:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar5,param2,puVar2[1]);
		      return;
		    }
		  }
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  uVar4 = unnamed_function_2232(&StringLiteral_9139);
		  System_String__Concat(uVar3,uVar4,0);
		  uVar4 = unnamed_function_2232
		                    (&
		                     Method_Core_Gameplay_Managers_GameActivityRouting_RoutingManager_HandleDeepLinkUriChangedEvent__
		                    );
		  func_ii_1050(uVar3,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C7A")]
		[Address(RVA = "0xB766", Offset = "0xB766", VA = "0xB766")]
		private void HandleDeepLinkUriChangedEvent(Uri uri)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_GameActivityRouting_RoutingManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6f8 = '\x01';
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
		void Core_Gameplay_Managers_GameActivityRouting_RoutingManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6f9 = '\x01';
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
		void Core_Gameplay_Managers_GameActivityRouting_RoutingManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6fa = '\x01';
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_RoutingManager__remove_DeinitCompleteEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a6fb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_13673);
		    DAT_ram_00a5a6fb = '\x01';
		  }
		  return StringLiteral_13673;
		}
		*/


		/* --- GHIDRA: set_Game ---
		void Core_Gameplay_Managers_GameActivityRouting_RoutingManager__set_Game
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int param1_00;
		  uint *puVar5;
		  uint uVar6;
		  int *param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a5a6fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_GameActivityRouting_Locators_App_ConnectAppLocator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Rounting_HttpLocator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_GameActivityRouting_LocatorRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_NotSupported___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_NotSupported__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25651);
		    DAT_ram_00a5a6fc = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = param2;
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_NotSupported__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_25651,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_NotSupported___ctor__
		            );
		  iVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository_TypeInfo
		                    );
		  if (DAT_ram_00a5a735 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__IPathNodeFactory__TypeInfo);
		    DAT_ram_00a5a735 = '\x01';
		  }
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_string__IPathNodeFactory__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory___ctor__);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository__TryGetFactory
		            (iVar2,iVar2);
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  iVar4 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator_TypeInfo
		                    );
		  if (DAT_ram_00a5a700 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_OpTokenRepository_TypeInfo);
		    DAT_ram_00a5a700 = '\x01';
		  }
		  uVar3 = unnamed_function_1417(Utils_OpTokenRepository_TypeInfo);
		  Utils_OpTokenRepository__Dispose(uVar3,0);
		  *(int *)(iVar4 + 0x10) = iVar2;
		  *(undefined4 *)(iVar4 + 0xc) = uVar1;
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  param1_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_GameActivityRouting_LocatorRepository_TypeInfo);
		  Core_Gameplay_Managers_GameActivityRouting_LocatorRepository__Dispose(param1_00,iVar4,iVar2);
		  uVar1 = unnamed_function_1417(Core_Rounting_HttpLocator_TypeInfo);
		  if (DAT_ram_00a5a6f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ILocator__Add__);
		    DAT_ram_00a5a6f5 = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_ILocator__Add__;
		  iVar4 = *(int *)(param1_00 + 8);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar4 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar6 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar6 = 0;
		  param1_01 = *(int **)(param1 + 0x14);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar6 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar6 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x8125d6a3;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar6);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125d6a3:
		  uVar1 = (**(code **)((ulonglong)*puVar5 * 4))(param1_01,puVar5[1]);
		  iVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_App_ConnectAppLocator_TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  if (DAT_ram_00a5a6f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ILocator__Add__);
		    DAT_ram_00a5a6f5 = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_ILocator__Add__;
		  param1_02 = *(int *)(param1_00 + 8);
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_02 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar6 * 4 + 0x10) = iVar2;
		    *(int *)(param1 + 0x10) = param1_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_02,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  *(int *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/

}
