using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x020013B4 RID: 5044
	[Token(Token = "0x20013B4")]
	public class ResourceManager : MonoBehaviour
	{
		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x060077E6 RID: 30694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017B7")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x60077E6")]
			[Address(RVA = "0xC140", Offset = "0xC140", VA = "0xC140")]
			get
			{
				return null;
			}
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E7")]
		[Address(RVA = "0xC141", Offset = "0xC141", VA = "0xC141")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077E8")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077E9")]
		[Address(RVA = "0xC142", Offset = "0xC142", VA = "0xC142")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00016080 File Offset: 0x00014280
		[Token(Token = "0x60077EA")]
		[Address(RVA = "0xC143", Offset = "0xC143", VA = "0xC143")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077EB")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077EC")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077ED")]
		[Address(RVA = "0xC144", Offset = "0xC144", VA = "0xC144")]
		public void CleanResourceCache(bool unloadResources = false)
		{
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077EE")]
		[Address(RVA = "0xC145", Offset = "0xC145", VA = "0xC145")]
		public ResourceManager()
		{
		}

		// Token: 0x04003EE1 RID: 16097
		[Token(Token = "0x4003EE1")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		// Token: 0x04003EE2 RID: 16098
		[Token(Token = "0x4003EE2")]
		[FieldOffset(Offset = "0x10")]
		public List<IResourceManager_Bundles> mBundleManagers;

		// Token: 0x04003EE3 RID: 16099
		[Token(Token = "0x4003EE3")]
		[FieldOffset(Offset = "0x14")]
		public UnityEngine.Object[] Assets;

		// Token: 0x04003EE4 RID: 16100
		[Token(Token = "0x4003EE4")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;
	}
}
