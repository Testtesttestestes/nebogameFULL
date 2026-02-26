using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.GameActivityRouting;
using Core.Gameplay.Managers.Requirements;
using Core.GameTime;
using Gameplay.Collections.Model.Factories;
using Gameplay.GdEvents.Model.Categories;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	public class GdEventsModel : AbstractModel, ITimeOffsetProvider
	{
		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000893")]
		public AbstractGdEventCatData MainCategory
		{
			[Token(Token = "0x6002C9C")]
			[Address(RVA = "0x7D29", Offset = "0x7D29", VA = "0x7D29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C9D")]
			[Address(RVA = "0x7D2A", Offset = "0x7D2A", VA = "0x7D2A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000894")]
		public List<AbstractGdEventCatData> Categories
		{
			[Token(Token = "0x6002C9E")]
			[Address(RVA = "0x7D2B", Offset = "0x7D2B", VA = "0x7D2B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C9F")]
			[Address(RVA = "0x7D2C", Offset = "0x7D2C", VA = "0x7D2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000895")]
		public TriggerDic[] TriggersForDetectCompletions
		{
			[Token(Token = "0x6002CA0")]
			[Address(RVA = "0x7D2D", Offset = "0x7D2D", VA = "0x7D2D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA1")]
			[Address(RVA = "0x7D2E", Offset = "0x7D2E", VA = "0x7D2E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000896")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6002CA2")]
			[Address(RVA = "0x7D2F", Offset = "0x7D2F", VA = "0x7D2F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA3")]
			[Address(RVA = "0x7D30", Offset = "0x7D30", VA = "0x7D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000897")]
		public ICurrentTimeProvider TimeProvider
		{
			[Token(Token = "0x6002CA4")]
			[Address(RVA = "0x7D31", Offset = "0x7D31", VA = "0x7D31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA5")]
			[Address(RVA = "0x7D32", Offset = "0x7D32", VA = "0x7D32")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000898")]
		public IRequirementValidator RequirementValidator
		{
			[Token(Token = "0x6002CA6")]
			[Address(RVA = "0x7D33", Offset = "0x7D33", VA = "0x7D33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA7")]
			[Address(RVA = "0x7D34", Offset = "0x7D34", VA = "0x7D34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000899")]
		public ICollectionDataFactory CollectionDataFactory
		{
			[Token(Token = "0x6002CA8")]
			[Address(RVA = "0x7D35", Offset = "0x7D35", VA = "0x7D35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA9")]
			[Address(RVA = "0x7D36", Offset = "0x7D36", VA = "0x7D36")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089A")]
		public IRouter Router
		{
			[Token(Token = "0x6002CAA")]
			[Address(RVA = "0x7D37", Offset = "0x7D37", VA = "0x7D37")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CAB")]
			[Address(RVA = "0x7D38", Offset = "0x7D38", VA = "0x7D38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089B")]
		public IRewardProvider RewardProvider
		{
			[Token(Token = "0x6002CAC")]
			[Address(RVA = "0x7D39", Offset = "0x7D39", VA = "0x7D39")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CAD")]
			[Address(RVA = "0x7D3A", Offset = "0x7D3A", VA = "0x7D3A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089C")]
		public GdEventIdsPrefs IdsPrefs
		{
			[Token(Token = "0x6002CAE")]
			[Address(RVA = "0x7D3B", Offset = "0x7D3B", VA = "0x7D3B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CAF")]
			[Address(RVA = "0x7D3C", Offset = "0x7D3C", VA = "0x7D3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089D")]
		public EventTabs EventTabs
		{
			[Token(Token = "0x6002CB0")]
			[Address(RVA = "0x7D3D", Offset = "0x7D3D", VA = "0x7D3D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB1")]
			[Address(RVA = "0x7D3E", Offset = "0x7D3E", VA = "0x7D3E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089E")]
		public SocialGiftDic DefaultGiftData
		{
			[Token(Token = "0x6002CB2")]
			[Address(RVA = "0x7D3F", Offset = "0x7D3F", VA = "0x7D3F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB3")]
			[Address(RVA = "0x7D40", Offset = "0x7D40", VA = "0x7D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089F")]
		public IGame Game
		{
			[Token(Token = "0x6002CB4")]
			[Address(RVA = "0x7D41", Offset = "0x7D41", VA = "0x7D41")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB5")]
			[Address(RVA = "0x7D42", Offset = "0x7D42", VA = "0x7D42")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x170008A0")]
		public ulong Offset
		{
			[Token(Token = "0x6002CB6")]
			[Address(RVA = "0x7D43", Offset = "0x7D43", VA = "0x7D43", Slot = "6")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A1")]
		public GdEventData CurrentEvent
		{
			[Token(Token = "0x6002CB7")]
			[Address(RVA = "0x7D44", Offset = "0x7D44", VA = "0x7D44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB8")]
			[Address(RVA = "0x7D45", Offset = "0x7D45", VA = "0x7D45")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB9")]
		[Address(RVA = "0x7D46", Offset = "0x7D46", VA = "0x7D46", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GdEvents_Model_GdEventsModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,int *param7,undefined4 param8,undefined4 param9,undefined4 param10)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  uint *puVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a5a2d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ContentResourceAsset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ContentStringMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Categories_CurrentCategory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__GdEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__GdEventData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_EventTabs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_GdEventIdsPrefs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AbstractGdEventCatData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__Add__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_RewardProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SocialGiftDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Categories_TimerStrings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Categories_UpcomingCategory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8337);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8330);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8322);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8340);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8339);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8323);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8336);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8324);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23322);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8331);
		    DAT_ram_00a5a2d4 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__GdEventData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__GdEventData___ctor__);
		  *(undefined4 *)(param1 + 0x44) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param9,0);
		  *(undefined4 *)(param1 + 0x28) = param3;
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x20) = param5;
		  *(undefined4 *)(param1 + 0x1c) = param6;
		  *(int **)(param1 + 0x18) = param7;
		  *(undefined4 *)(param1 + 0x14) = param8;
		  uVar2 = unnamed_function_1417(Gameplay_GdEvents_Model_RewardProvider_TypeInfo);
		  Gameplay_GdEvents_Model_RewardProvider__TryGetReward(uVar2,uVar2);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  uVar2 = unnamed_function_1417(Gameplay_GdEvents_Model_GdEventIdsPrefs_TypeInfo);
		  Gameplay_GdEvents_Model_GdEventData__SetSelectedMileStone(uVar2,StringLiteral_23322,uVar2);
		  *(undefined4 *)(param1 + 0x30) = uVar2;
		  uVar2 = unnamed_function_1417(Gameplay_GdEvents_Model_EventTabs_TypeInfo);
		  Gameplay_GdEvents_View_EntryPoint_GdEventsIndexEpView___ctor(uVar2,uVar2);
		  *(undefined4 *)(param1 + 0x34) = uVar2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_8337,1,0,1,0,0,0,0);
		  uVar3 = func_ii_7508(StringLiteral_8336,1,0,1,0,0,0,0);
		  uVar4 = func_ii_7508(StringLiteral_8340,1,0,1,0,0,0,0);
		  uVar5 = func_ii_7508(StringLiteral_8339,1,0,1,0,0,0,0);
		  iVar6 = unnamed_function_1417(Gameplay_GdEvents_Model_Categories_TimerStrings_TypeInfo);
		  if (DAT_ram_00a5a2f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a2f5 = '\x01';
		  }
		  *(int *)(iVar6 + 0x18) = StringLiteral_5;
		  *(undefined4 *)(iVar6 + 0x14) = uVar5;
		  *(undefined4 *)(iVar6 + 0x10) = uVar4;
		  *(undefined4 *)(iVar6 + 0xc) = uVar3;
		  *(undefined4 *)(iVar6 + 8) = uVar2;
		  *(int *)(param1 + 0x40) = iVar6;
		  uVar2 = func_ii_7508(StringLiteral_8322,1,0,1,0,0,0,0);
		  uVar3 = *(undefined4 *)(param1 + 0x40);
		  iVar6 = unnamed_function_1417(Gameplay_GdEvents_Model_Categories_CurrentCategory_TypeInfo);
		  if (DAT_ram_00a5a2eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GdEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GdEventData__TypeInfo);
		    DAT_ram_00a5a2eb = '\x01';
		  }
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_GdEventData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_GdEventData___ctor__);
		  *(undefined4 *)(iVar6 + 0xc) = uVar4;
		  *(undefined4 *)(iVar6 + 0x14) = param6;
		  *(undefined4 *)(iVar6 + 8) = uVar2;
		  *(undefined4 *)(iVar6 + 0x18) = uVar3;
		  *(int *)(iVar6 + 0x10) = param1;
		  *(int *)(param1 + 0xc) = iVar6;
		  iVar7 = unnamed_function_1417(System_Collections_Generic_List_AbstractGdEventCatData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar7,Method_System_Collections_Generic_List_AbstractGdEventCatData___ctor__);
		  iVar6 = Method_System_Collections_Generic_List_AbstractGdEventCatData__Add__;
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar9 = *(uint *)(iVar7 + 0xc);
		  if (uVar9 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar9 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar9 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = func_ii_7508(StringLiteral_8323,1,0,1,0,0,0,0);
		  uVar3 = *(undefined4 *)(param1 + 0x40);
		  iVar6 = unnamed_function_1417(Gameplay_GdEvents_Model_Categories_UpcomingCategory_TypeInfo);
		  if (DAT_ram_00a5a2eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GdEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GdEventData__TypeInfo);
		    DAT_ram_00a5a2eb = '\x01';
		  }
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_GdEventData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_GdEventData___ctor__);
		  *(undefined4 *)(iVar6 + 0xc) = uVar4;
		  *(undefined4 *)(iVar6 + 0x14) = param6;
		  *(undefined4 *)(iVar6 + 8) = uVar2;
		  *(undefined4 *)(iVar6 + 0x18) = uVar3;
		  *(int *)(iVar6 + 0x10) = param1;
		  iVar1 = Method_System_Collections_Generic_List_AbstractGdEventCatData__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar9 = *(uint *)(iVar7 + 0xc);
		  if (uVar9 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar9 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar9 * 4 + 0x10) = iVar6;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar9 = 0;
		  iVar6 = unnamed_function_1417(Protocol_Dic_SocialGiftDic_TypeInfo);
		  Protocol_Dic_SocialGiftDic__pb__Google_Protobuf_IMessage_get_Descriptor(iVar6,0);
		  *(undefined1 *)(iVar6 + 0x14) = 0;
		  *(int *)(param1 + 0x38) = iVar6;
		  uVar3 = *(undefined4 *)(iVar6 + 0x2c);
		  iVar6 = unnamed_function_1417(Protocol_Common_ContentStringMessage_TypeInfo);
		  Protocol_Common_ContentStringMessage__pb__Google_Protobuf_IMessage_get_Descriptor(iVar6,0);
		  *(undefined4 *)(iVar6 + 0xc) = 0x52;
		  uVar2 = func_ii_7508(StringLiteral_8331,1,0,1,0,0,0,0);
		  Protocol_Common_ContentStringMessage__get_Message(iVar6,uVar2,0);
		  func_ii_6441(uVar3,iVar6,
		               Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__Add__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0x28);
		  iVar6 = unnamed_function_1417(Protocol_Common_ContentResourceAsset_TypeInfo);
		  Protocol_Common_ContentResourceAsset__pb__Google_Protobuf_IMessage_get_Descriptor(iVar6,0);
		  *(undefined4 *)(iVar6 + 0xc) = 5;
		  iVar7 = *param7;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		        puVar8 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x811f8380;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		  }
		  puVar8 = (uint *)func_ii_1080(param7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811f8380:
		  uVar3 = (**(code **)((ulonglong)*puVar8 * 4))(param7,puVar8[1]);
		  iVar7 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar3,StringLiteral_8330,0);
		  if (iVar7 == 0) {
		    iVar7 = StringLiteral_5;
		  }
		  Protocol_Common_ContentResourceAsset__get_AssetId(iVar6,iVar7,0);
		  func_ii_6441(uVar2,iVar6,
		               Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__Add__);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_8324,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x48) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CBA")]
		[Address(RVA = "0x7D47", Offset = "0x7D47", VA = "0x7D47")]
		public GdEventsModel(IGame game, IRouter router, ICollectionDataFactory collectionDataFactory, IRequirementValidator requirementValidator, ICurrentTimeProvider timeProvider, IDictProvider dictProvider, TriggerDic[] triggersForDetectCompletions, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GdEvents_Model_GdEventsModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 param6;
		  undefined4 param5;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  if (DAT_ram_00a5a2d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__GdEventData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__GdEventData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_GdEventData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    DAT_ram_00a5a2d5 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x44),*(undefined4 *)(param2 + 0xc),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__GdEventData__TryGetValue__);
		  if (iVar1 == 0) {
		    param6 = *(undefined4 *)(param1 + 0x34);
		    param5 = *(undefined4 *)(param1 + 8);
		    param4 = *(undefined4 *)(param1 + 0x2c);
		    param3_00 = *(undefined4 *)(param1 + 0x20);
		    iVar1 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(iVar1,0);
		    *(undefined4 *)(iVar1 + 0x18) = *(undefined4 *)(param1 + 0x48);
		    param1_00 = unnamed_function_1417(Gameplay_GdEvents_Model_GdEventData_TypeInfo);
		    Gameplay_GdEvents_Model_GdEventData__set_SelectedMilestone
		              (param1_00,param2,param3_00,param4,param5,param6,iVar1,auStack_10);
		    local_4 = param1_00;
		    System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		              (*(undefined4 *)(param1 + 0x44),*(undefined4 *)(*(int *)(param1_00 + 0x10) + 0xc),
		               param1_00,Method_System_Collections_Generic_Dictionary_uint__GdEventData__Add__);
		  }
		  else {
		    *(int *)(local_4 + 0x10) = param2;
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CBB")]
		[Address(RVA = "0x7D48", Offset = "0x7D48", VA = "0x7D48")]
		public GdEventData GetEvent(GameEventDic dict)
		{
		/* --- GHIDRA: GetEvent ---
		undefined4 Gameplay_GdEvents_Model_GdEventsModel__GetEvent(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a5a2d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__GdEventData__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__GdEventData__TryGetValue__);
		    DAT_ram_00a5a2d6 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x44),*(undefined4 *)(param2 + 0xc),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__GdEventData__TryGetValue__);
		  if (iVar1 != 0) {
		    func_ii_8588(local_4,auStack_10);
		    uVar2 = System_Collections_Generic_List_Enumerator_uint___MoveNext
		                      (*(undefined4 *)(param1 + 0x44),*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__GdEventData__Remove__);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x7D49", Offset = "0x7D49", VA = "0x7D49")]
		public bool RemoveEvent(GameEventDic value)
		{
		/* --- GHIDRA: RemoveEvent ---
		void Gameplay_GdEvents_Model_GdEventsModel__RemoveEvent(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a2d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__RewardInfo____Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___Clear__
		              );
		    DAT_ram_00a5a2d7 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_uint__RewardInfo____Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0xc),
		             Method_System_Collections_Generic_Dictionary_uint__List_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___Clear__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04001885 RID: 6277
		[Token(Token = "0x4001885")]
		public const string GD_EVENTS_NOTVIEWED_IDS = "gd_events_notviewed_ids";

		// Token: 0x04001886 RID: 6278
		[Token(Token = "0x4001886")]
		public const string DEFAULT_EP_ICON_RES_KEY = "EVENT_LIBRARY";

		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		[FieldOffset(Offset = "0x40")]
		private TimerStrings _timerStrings;

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[FieldOffset(Offset = "0x44")]
		private Dictionary<uint, GdEventData> _events;

		// Token: 0x04001896 RID: 6294
		[Token(Token = "0x4001896")]
		[FieldOffset(Offset = "0x48")]
		private string _progressValueTemplate;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		undefined8 Gameplay_GdEvents_Model_GdEventsModel__set_Game(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  undefined8 uVar2;
		  int *param1_01;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a2d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23313);
		    DAT_ram_00a5a2d2 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811f7a9b;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811f7a9b:
		  param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetDoubleParameter(param1_00,StringLiteral_23313,0);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: set_CurrentEvent ---
		void Gameplay_GdEvents_Model_GdEventsModel__set_CurrentEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a2d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__GdEventData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__GdEventData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GdEventData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GdEventData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GdEventData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractGdEventCatData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__GdEventData__GetEnumerator__
		              );
		    DAT_ram_00a5a2d3 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x44),
		                     Method_System_Collections_Generic_Dictionary_uint__GdEventData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__GdEventData__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GdEventData__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f7c07;
		    }
		    iVar6 = local_18;
		    if (iVar3 == 0) goto code_r0x811f7c50;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x289,local_8._4_4_,auStack_20);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f7c07:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar6 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar6;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x811f7c50:
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 0x44),
		                 Method_System_Collections_Generic_Dictionary_uint__GdEventData__Clear__);
		      iVar6 = *(int *)(param1 + 0x10);
		      iVar3 = *(int *)(iVar6 + 0xc);
		      *(undefined4 *)(iVar6 + 0xc) = 0;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar3,0);
		      }
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 0x2c);
		      iVar6 = *piVar4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_GdEvents_Model_IRewardProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811f7d1c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,0);
		code_r0x811f7d1c:
		      (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      *(undefined4 *)(param1 + 0x4c) = 0;
		      *(undefined4 *)(param1 + 0xc) = 0;
		      *(undefined8 *)(param1 + 0x14) = 0;
		      *(undefined8 *)(param1 + 0x1c) = 0;
		      *(undefined8 *)(param1 + 0x24) = 0;
		      *(undefined8 *)(param1 + 0x2c) = 0;
		      *(undefined8 *)(param1 + 0x34) = 0;
		      *(undefined4 *)(param1 + 0x3c) = 0;
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x28a,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
