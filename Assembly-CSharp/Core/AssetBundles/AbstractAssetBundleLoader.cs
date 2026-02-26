using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Files;
using Core.Gameplay.Managers.Configuration;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.AssetBundles
{
	// Token: 0x02001110 RID: 4368
	[Token(Token = "0x2001110")]
	public abstract class AbstractAssetBundleLoader : IDisposable
	{
		// Token: 0x14000245 RID: 581
		// (add) Token: 0x060065E6 RID: 26086 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060065E7 RID: 26087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000245")]
		private event Action<string> DisposeCompleteEvent
		{
			[Token(Token = "0x60065E6")]
			[Address(RVA = "0xB16F", Offset = "0xB16F", VA = "0xB16F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60065E7")]
			[Address(RVA = "0xB170", Offset = "0xB170", VA = "0xB170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E8")]
		[Address(RVA = "0xB171", Offset = "0xB171", VA = "0xB171")]
		public void DisposeOnLoad(Action<string> callback)
		{
		/* --- GHIDRA: DisposeOnLoad ---
		void Core_AssetBundles_AbstractAssetBundleLoader__DisposeOnLoad(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x32) = 0;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0xB172", Offset = "0xB172", VA = "0xB172")]
		public void DontDisposeOnLoad()
		{
		/* --- GHIDRA: DontDisposeOnLoad ---
		void Core_AssetBundles_AbstractAssetBundleLoader__DontDisposeOnLoad
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a8e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Action_AssetBundle____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Action___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Action_AssetBundle___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Action__TypeInfo);
		    DAT_ram_00a5a8e9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Action_AssetBundle___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Action_AssetBundle____ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Action__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Action___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param5;
		  *(undefined1 *)(param1 + 9) = (undefined1)param6;
		  return;
		}
		*/

		}

		// Token: 0x060065EA RID: 26090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0xB173", Offset = "0xB173", VA = "0xB173")]
		protected AbstractAssetBundleLoader(IFileManager fileProvider, IPlatformConfigurationProvider configurationProvider, string platformName, string path, bool cacheOnDevice)
		{
		/* --- GHIDRA: .ctor ---
		void Core_AssetBundles_AbstractAssetBundleLoader___ctor(int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param2_00;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a8eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_IFileContent_TypeInfo);
		    DAT_ram_00a5a8eb = '\x01';
		  }
		  local_4 = 0;
		  if ((char)param1[2] == '\0') {
		    uVar1 = 0;
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Files_IFileContent_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x8128b0dc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    param2_00 = (uint *)func_ii_1080(param2,Core_Files_IFileContent_TypeInfo,1);
		code_r0x8128b0dc:
		    iVar2 = (**(code **)((ulonglong)*param2_00 * 4))(param2,&local_4,param2_00[1]);
		    if (iVar2 == 0) {
		      *(undefined1 *)(param1 + 0xc) = 1;
		      func_ii_8824(param1,param2_00);
		    }
		    else {
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                (param1,local_4,*(undefined4 *)(*param1 + 0xec));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060065EB RID: 26091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0x446B", Offset = "0x446B", VA = "0x446B")]
		public void Load()
		{
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0xB174", Offset = "0xB174", VA = "0xB174")]
		private void OnAssetBundleBytesReady(IFileContent content)
		{
		/* --- GHIDRA: OnAssetBundleBytesReady ---
		void Core_AssetBundles_AbstractAssetBundleLoader__OnAssetBundleBytesReady
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_UniTaskVoid__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_AssetBundles_AbstractAssetBundleLoader___c__DisplayClass24_0__CreateAssetBundleFromBytes_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_AssetBundles_AbstractAssetBundleLoader___c__DisplayClass24_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a5a8ec = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Core_AssetBundles_AbstractAssetBundleLoader___c__DisplayClass24_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  *(undefined1 *)(param1 + 0x31) = 1;
		  param1_00 = unnamed_function_1417(System_Func_UniTaskVoid__TypeInfo);
		  System_Func_UniTask___Invoke
		            (param1_00,param2_00,
		             Method_Core_AssetBundles_AbstractAssetBundleLoader___c__DisplayClass24_0__CreateAssetBundleFromBytes_b__0__
		             ,0);
		  if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		  }
		  Cysharp_Threading_Tasks_UniTask__Create(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0xB175", Offset = "0xB175", VA = "0xB175", Slot = "5")]
		protected virtual void CreateAssetBundleFromBytes(byte[] bytes)
		{
		/* --- GHIDRA: CreateAssetBundleFromBytes ---
		void Core_AssetBundles_AbstractAssetBundleLoader__CreateAssetBundleFromBytes
		               (undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_1c;
		  longlong local_18;
		  ulonglong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a8ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractAssetBundleLoader__LoadFromMemoryAsync_d__25___
		              );
		    DAT_ram_00a5a8ed = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (ulonglong)param2;
		  local_1c = 0xffffffff;
		  local_18 = (ulonglong)param3 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start___Il2CppFullySharedGenericType_
		            (&local_18,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractAssetBundleLoader__LoadFromMemoryAsync_d__25___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x060065EE RID: 26094 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0xB176", Offset = "0xB176", VA = "0xB176", Slot = "6")]
		protected virtual UniTaskVoid LoadFromMemoryAsync(byte[] bytes)
		{
		/* --- GHIDRA: LoadFromMemoryAsync ---
		void Core_AssetBundles_AbstractAssetBundleLoader__LoadFromMemoryAsync(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 8) == '\0') {
		    iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                      (*(undefined4 *)(param1 + 0x24),0);
		    if (iVar1 != 0) {
		      UnityEngine_AssetBundle__LoadAllAssetsAsync(*(undefined4 *)(param1 + 0x24),1,0);
		      *(undefined4 *)(param1 + 0x24) = 0;
		    }
		    *(undefined1 *)(param1 + 8) = 1;
		    iVar1 = *(int *)(param1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0xc),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EF")]
		[Address(RVA = "0x446A", Offset = "0x446A", VA = "0x446A")]
		public void AddCallback(Action<AssetBundle> successCallback, Action failCallback)
		{
		/* --- GHIDRA: AddCallback ---
		void Core_AssetBundles_AbstractAssetBundleLoader__AddCallback(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int iVar5;
		  undefined4 uVar6;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a5a8ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_AssetBundles_AbstractAssetBundleLoader_OnAssetBundleBytesReady__);
		    Mono_Security_ASN1__get_Item(&System_Action_IFileContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Files_IFileManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    DAT_ram_00a5a8ea = '\x01';
		  }
		  uVar3 = Core_AssetBundles_AbstractAssetBundleLoader__Dispose
		                    (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0xc),0);
		  param1_01 = *(int **)(param1 + 0x14);
		  param1_02 = *(int **)(param1 + 0x18);
		  iVar5 = *param1_02;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8128ade6;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_02,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,0);
		code_r0x8128ade6:
		  iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_02,puVar4[1]);
		  uVar6 = *(undefined4 *)(iVar5 + 0x14);
		  cVar1 = *(char *)(param1 + 9);
		  uVar2 = 0;
		  param1_00 = unnamed_function_1417(System_Action_IFileContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_AssetBundles_AbstractAssetBundleLoader_OnAssetBundleBytesReady__,0);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Files_IFileManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8128ae9e;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Files_IFileManager_TypeInfo,0);
		code_r0x8128ae9e:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar6,uVar3,cVar1 != '\0',param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F0")]
		[Address(RVA = "0x2279", Offset = "0x2279", VA = "0x2279")]
		protected void CheckIfReady()
		{
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F1")]
		[Address(RVA = "0xB177", Offset = "0xB177", VA = "0xB177", Slot = "7")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4
		Core_AssetBundles_AbstractAssetBundleLoader__Dispose(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 uVar4;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a8f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20794);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1606);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1605);
		    DAT_ram_00a5a8f0 = '\x01';
		  }
		  if (DAT_ram_00a664bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_ReadOnlySpan_char___ctor__);
		    DAT_ram_00a664bf = '\x01';
		  }
		  if (param2 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar2 = UnityEngine_Bindings_ManagedSpanWrapper___ctor(param2,0);
		    uVar4 = CONCAT44(*(undefined4 *)(param2 + 8),uVar2);
		  }
		  iVar1 = StringLiteral_1606;
		  if (DAT_ram_00a664ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_ReadOnlySpan_char___ctor__);
		    DAT_ram_00a664ba = '\x01';
		  }
		  if (iVar1 == 0) {
		    local_20 = 0;
		  }
		  else {
		    uVar2 = UnityEngine_Bindings_ManagedSpanWrapper___ctor(iVar1,0);
		    local_20 = CONCAT44(*(undefined4 *)(iVar1 + 8),uVar2);
		  }
		  local_18 = uVar4;
		  local_10 = local_20;
		  local_8 = uVar4;
		  iVar1 = System_MemoryExtensions__ToUpperInvariant(&local_18,&local_20,4,0);
		  if (iVar1 != 0) {
		    param2 = System_Data_DataSet__ReadXmlSchema
		                       (param2,0,*(int *)(param2 + 8) - *(int *)(StringLiteral_1606 + 8),0);
		  }
		  uVar2 = unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  System_Text_Latin1Encoding___cctor(uVar2,param1,0);
		  uVar2 = func_ii_2010(uVar2,StringLiteral_1618,0);
		  uVar2 = func_ii_2010(uVar2,StringLiteral_20794,0);
		  uVar2 = func_ii_2010(uVar2,param2,0);
		  piVar3 = (int *)func_ii_2010(uVar2,StringLiteral_1605,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xd8) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0xdc));
		  return uVar2;
		}
		*/

		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065F2")]
		[Address(RVA = "0xB178", Offset = "0xB178", VA = "0xB178")]
		[CompilerGenerated]
		internal static string <Load>g__GetBundleUrlByResourceUrl|22_0(string platformName, string url)
		{
			return null;
		}

		// Token: 0x04003671 RID: 13937
		[Token(Token = "0x4003671")]
		private const string UnityPackageExtension = ".unitypackage";

		// Token: 0x04003672 RID: 13938
		[Token(Token = "0x4003672")]
		private const string Unity3dExtension = ".unity3d";

		// Token: 0x04003673 RID: 13939
		[Token(Token = "0x4003673")]
		private const string BundlesDir = "bundles/";

		// Token: 0x04003674 RID: 13940
		[Token(Token = "0x4003674")]
		[FieldOffset(Offset = "0x8")]
		private bool _isDisposed;

		// Token: 0x04003675 RID: 13941
		[Token(Token = "0x4003675")]
		[FieldOffset(Offset = "0x9")]
		public readonly bool CacheOnDevice;

		// Token: 0x04003676 RID: 13942
		[Token(Token = "0x4003676")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _path;

		// Token: 0x04003677 RID: 13943
		[Token(Token = "0x4003677")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _platformName;

		// Token: 0x04003678 RID: 13944
		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x14")]
		private readonly IFileManager _fileProvider;

		// Token: 0x04003679 RID: 13945
		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x18")]
		private readonly IPlatformConfigurationProvider _configurationProvider;

		// Token: 0x0400367B RID: 13947
		[Token(Token = "0x400367B")]
		[FieldOffset(Offset = "0x20")]
		public int Counter;

		// Token: 0x0400367C RID: 13948
		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0x24")]
		private AssetBundle _bundle;

		// Token: 0x0400367D RID: 13949
		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<Action<AssetBundle>> _successCallbacks;

		// Token: 0x0400367E RID: 13950
		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<Action> _failCallbacks;

		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x30")]
		private bool _failed;

		// Token: 0x04003680 RID: 13952
		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x31")]
		private bool _isLoading;

		// Token: 0x04003681 RID: 13953
		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0x32")]
		private bool _disposeOnLoad;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_DisposeCompleteEvent ---
		void Core_AssetBundles_AbstractAssetBundleLoader__add_DisposeCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a5a8e8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_DisposeCompleteEvent ---
		void Core_AssetBundles_AbstractAssetBundleLoader__remove_DisposeCompleteEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  *(undefined1 *)((int)param1 + 0x32) = 1;
		  param1[7] = param2;
		  if (*(char *)((int)param1 + 0x31) == '\0') {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))(param1,*(undefined4 *)(*param1 + 0xfc));
		  }
		  return;
		}
		*/

}
